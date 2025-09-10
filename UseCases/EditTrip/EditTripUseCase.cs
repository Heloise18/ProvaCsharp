using Microsoft.EntityFrameworkCore;
using prova.UseCase.EditTrip;
using prova.UseCases.GetTrip;
using Prova;
using Prova.Entities;

namespace prova.UseCases.EditTrip;

public class EditTripUseCase(
    PlanDbContext ctx
)
{
    public async Task<Result<EditTripResponse>> Do(EditTripRequest request)
    {
        var Trip = await ctx.Trips.FirstOrDefaultAsync(t => t.ID == request.TripID);

        if (Trip is null)
            return Result<EditTripResponse>.Fail("List not found");
        if (Trip.OwnerID != request.Ownerid)
            return Result<EditTripResponse>.Fail("Access denied");

        var place = await ctx.Places.FirstOrDefaultAsync(t => t.ID == request.PlaceID);

        Trip.Attractions.Add(place);
        await ctx.SaveChangesAsync(); 

        return Result<EditTripResponse>.Success(new());
    }

}

