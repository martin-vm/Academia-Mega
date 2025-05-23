var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddControllers();
var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();


//@->20250514T0855 Siempre debe de ir al último !!!
app.Run();


