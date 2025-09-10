using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Prova.Entities;

public class PlanDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Place> Places => Set<Place>();
    public DbSet<Trip> Trips => Set<Trip>();
    public DbSet<User> Users => Set<User>();
    public DbSet<PlaceTrip> PlaceTrips => Set<PlaceTrip>();

    protected override void OnModelCreating(ModelBuilder model)
    {

        model.Entity<Trip>()
        .HasOne(t => t.Users)
        .WithMany(u => u.Trips)
        .HasForeignKey(u => u.OwnerID)
        .OnDelete(DeleteBehavior.NoAction);

        model.Entity<PlaceTrip>()
        .HasOne(p => p.Places)
        .WithMany(i => i.intermediaria)
        .OnDelete(DeleteBehavior.NoAction);

        model.Entity<PlaceTrip>()
        .HasOne(p => p.Trips)
        .WithMany(i => i.intermediaria)
        .OnDelete(DeleteBehavior.NoAction);

        
        model.Entity<User>();

        model.Entity<PlaceTrip>();
        
        model.Entity<Trip>();

        model.Entity<Place>();

    }
}


//Um visitante pode ter muitas listas salvas e as listas tem muitos pontos e os pontos podem estar em muitas listas




public class RPlaceDbContextFactory : IDesignTimeDbContextFactory<PlanDbContext>
{
    public PlanDbContext CreateDbContext(string[] args)
    {
        var options = new DbContextOptionsBuilder<PlanDbContext>();
        var sqlConn = Environment.GetEnvironmentVariable("SQL_CONNECTION");
        options.UseSqlServer(sqlConn);
        return new PlanDbContext(options.Options);
    }
}