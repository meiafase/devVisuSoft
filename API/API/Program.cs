var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Rota padrão");


app.MapGet("/rotaDois", () => "Rota rota Dois");


app.Run();
