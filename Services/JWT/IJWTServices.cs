using Prova.Entities;

public interface IJWTService
{
    string CreateToken(User data);
}