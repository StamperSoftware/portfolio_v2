using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();
builder.Services.AddControllers();

var dbConnectionString = builder.Environment.IsDevelopment() ? builder.Configuration.GetConnectionString("DefaultConnection") 
    : Environment.GetEnvironmentVariable("PORTFOLIO_DB_CONNECTION");

builder.Services.AddDbContext<PortfolioContext>(options => options.UseNpgsql(dbConnectionString));
builder.Services.AddScoped<ITrackerService, TrackerService>();

var app = builder.Build();
app.UseCors(policy => policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://localhost:4200"));
app.UseDefaultFiles();
app.UseStaticFiles();


app.MapControllers();
app.MapFallbackToController("Index", "Fallback");
app.UseHttpsRedirection();
app.Run();