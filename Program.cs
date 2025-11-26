using Esakay.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// ==========================================
// 1. SETUP NG DATABASE CONNECTION (MySQL)
// ==========================================
// Kinukuha nito ang settings mula sa appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Ikinokonekta ang AppDbContext sa MySQL database
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// ==========================================
// 2. SETUP NG SERVICES (Controllers & Swagger)
// ==========================================
builder.Services.AddControllers(); // Importante: Para gumana ang VehiclesController
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // Para sa testing UI

var app = builder.Build();

// ==========================================
// 3. CONFIGURE HTTP PIPELINE
// ==========================================
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// Importante: Ito ang maghahanap sa VehiclesController.cs na ginawa mo
app.MapControllers(); 

app.Run();