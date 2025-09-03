using System.ComponentModel.DataAnnotations;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Olá mundo!");

app.MapPost("/login", (MibimalApi.DTOsLoginDTO loginDTO) =>
{
    if (loginDTO.Email == "adm@teste.com" && loginDTO.Senha == "123456")
        return Results.Ok("Login com sucesso");
    else
        return Results.Unauthorized();
});

app.Run();

public class LoginDTO
{
    [EmailAddress]
    public string Email { get; set; } = default!;

    public string Senha { get; set; } = default!;
}
