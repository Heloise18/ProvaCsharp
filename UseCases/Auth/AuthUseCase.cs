using Microsoft.EntityFrameworkCore;
using Prova;
using Prova.Entities;

namespace prova.UseCases.Auth;

public class AuthUseCase(
    PlanDbContext ctx,
    IJWTService jWTService
)
{
     public async Task<Result<AuthResponse>> Do(AuthRequest request)
    {
        var user = await ctx.Users
            .FirstOrDefaultAsync(u => u.Username == request.Username);

        if (user is null)
            return Result<AuthResponse>.Fail("Username or Password is wrong");

    
        if (user.Password == request.Password)
            return Result<AuthResponse>.Fail("Username or Password is wrong");
        

        var jwt = jWTService.CreateToken(new(
            user.ID,
            user.Username
        ));

        var response = new AuthResponse(jwt);

        return Result<AuthResponse>.Success(response);
    }
}