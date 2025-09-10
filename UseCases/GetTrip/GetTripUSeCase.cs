using Microsoft.EntityFrameworkCore;
using prova.UseCases.CreatTrip;
using Prova;
using Prova.Entities;

namespace prova.UseCases.GetTrip;

public class GetTripUseCase(
    PlanDbContext ctx
)
{
    public async Task<Result<GetTripResponse>> Do(GetTripRequest request)
    {
        var Trips = await ctx.Trips
            .FirstOrDefaultAsync(t => t.ID == request.TripID);

        if (Trips is null)
            return Result<GetTripResponse>.Fail("Trip not found");

        var response = new GetTripResponse(
            Trips.Title,
            Trips.Description,
            Trips.Owner,
            Trips.Attractions
        );

        return Result<GetTripResponse>.Success(response);
    }
}
