namespace prova.UseCases.Auth;

public record AuthRequest (
    string Username,
    string Password
);