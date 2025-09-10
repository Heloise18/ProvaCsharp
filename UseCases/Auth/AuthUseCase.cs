using Microsoft.EntityFrameworkCore;
using Prova;
using Prova.Entities;

namespace prova.UseCases.Auth;

public class AuthUseCase(
    PlanDbContext ctx
)
{
     public async Task<Result<AuthResponse>> Do(AuthRequest request)
    {
        // var user = await ctx.Users
        //     .FirstOrDefaultAsync(u => u.Email == request.Login);

        // if (user is null)
        //     return Result<LoginResponse>
        //         .Fail("User not found!");

        // var PassWordMatch = passwordService
        //     .Compare(request.PassWord, user.PassWord);
        // if (PassWordMatch is false)
        //     return Result<LoginResponse>.Fail("User not found!");

        // var jwt = jWTService.CreateToken(new(
        //     user.ID, user.Name
        // ));

        return Result<AuthResponse>.Success(null);
    }
}