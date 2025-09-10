using prova.UseCases.GetTrip;
using Prova;
using Prova.Entities;

namespace prova.UseCases.CreatTrip;

public class CreateTripUseCase (
    PlanDbContext ctx
)
{
    public async Task<Result<CreateTripResponse>> Do(CreateTripRequest request)
    {
    //     var trip = new CreateTripRequest(
    //         request.Title,
    //         request.Description
    //     );
    //     ctx.Trips.Add(trip);
    //     await ctx.SaveChangesAsync();

         return Result<CreateTripResponse>.Success(null);
    }

}