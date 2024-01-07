using ControllerBot.Migrations;
using ControllerBot.Services;
using ControllerBot.Services.Interfaces;
using ControllerBot.VKAPI;
using ControllerBot.VKAPI.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddTransient<IMainService, MainService>();

builder.Services.AddTransient<IVKAPI, VKAPI>();

var app = builder.Build();
Migrator.Migrate(app);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();