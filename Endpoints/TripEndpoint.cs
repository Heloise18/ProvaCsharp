using Microsoft.AspNetCore.Mvc;
using prova.Payload;
using prova.UseCases.Auth;
using prova.UseCases.CreatTrip;

namespace prova.Endpoint;

public static class AuthTripEndpoint
{
    public static void ConfigureTripEndpoints(this WebApplication app)
    {
        app.MapPost("CreateTrip/{TripID}", async (
            HttpContext http,
            Guid TripID,
            [FromBody] TripData payload,
            [FromServices] CreateTripUseCase usecase) =>
        {

        });

        app.MapPut("EditTrip", async (
            HttpContext http,
            [FromBody] TripData payload,
            [FromServices] CreateTripUseCase usecase) =>
        {

        });

        app.MapGet("GetTrip", async (
            HttpContext http,
            string title,
            [FromServices] CreateTripUseCase usecase) =>
        {

        });


    }
}

