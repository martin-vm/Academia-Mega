using TaskManager.Models;
using TaskManager.Services;
using TaskManager.Repositories;
using Microsoft.Extensions.DependencyInjection;
using TaskManager.Shared.PubSub;
using TaskManager.Hubs;


var builder = WebApplication.CreateBuilder(args);

var AllowedOrigin = "BlazorClient";

builder.Services.AddCors(options =>
{
    options.AddPolicy(AllowedOrigin, policy =>
    {
        policy.WithOrigins("http://localhost:5149")
            .AllowAnyHeader()
            .AllowAnyMethod();
        //.AllowCredentials() Solo si usamos una cookie de Sesión.
    });
});

builder.Services.AddControllers();

builder.Services.AddScoped<INotificationService, EmailNotificationService>();
builder.Services.AddScoped<INotificationService, SmsNotificationService>();
builder.Services.AddSingleton<ITaskRepository, InMemoryTaskRepository>();

builder.Services.AddSingleton<EventBus>();
builder.Services.AddSignalR();

builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapControllers();

app.MapHub<TaskEventHub>("/taskEvents");

app.UseSwagger();
app.UseSwaggerUI();
app.UseCors(AllowedOrigin);

app.UseHttpsRedirection();


app.Run();