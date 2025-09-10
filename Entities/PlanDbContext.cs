using Microsoft.EntityFrameworkCore;

namespace Prova.Entities;

public class PlanDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Place> Places => Set<Place>();
    public DbSet<Trip> Trips => Set<Trip>();
    public DbSet<User> Users => Set<User>();
    public DbSet<VisitorsPlaces> VisitorsPlace=> Set<VisitorsPlaces>();

     protected override void OnModelCreating(ModelBuilder model)
    {


        model.Entity<User>();

    }
}