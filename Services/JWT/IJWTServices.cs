using Prova.Entities;

public interface IJWTService
{
    string CreateToken(UserData data);
}