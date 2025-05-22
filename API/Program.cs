var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();
builder.Services.AddCors();
builder.Services.AddControllers();

var app = builder.Build();
app.UseCors(policy => policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://localhost:4200"));
app.UseDefaultFiles();
app.UseStaticFiles();
app.MapControllers();
app.MapFallbackToController("Index", "Fallback");
app.UseHttpsRedirection();
app.Run();