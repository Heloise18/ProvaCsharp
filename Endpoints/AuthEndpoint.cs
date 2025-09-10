using Microsoft.AspNetCore.Mvc;
using prova.UseCases.Auth;

namespace prova.Endpoint;

public static class AuthEndpoints
{
   public static void ConfigureAuthEndpoints(this WebApplication app)
    {
        app.MapPost("auth", async (
            HttpContext http,
            [FromBody] AuthRequest request,
            [FromServices]AuthUseCase useCase) =>
        {
            var response = await useCase.Do(request);

            if (!response.IsSuccess && response.Reason == "Username or Password is wrong")
                return Results.Unauthorized();

            return Results.Ok(response);
        });
    }
}