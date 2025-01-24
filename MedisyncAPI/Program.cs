using MedisyncAPI.Data;
using MedisyncAPI.Repositories.Classes;
using MedisyncAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 1. Register the DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2. Add controller support
builder.Services.AddControllers();


builder.Services.AddScoped<IMedicationRepository, MedicationRepository>();
builder.Services.AddScoped<IInteractionRepository, InteractionRepository>();

// 3. Enable Swagger Services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddLogging();

var app = builder.Build();

// 4. Configure the middleware
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    // Serve the Swagger UI at /swagger
    app.UseSwagger();
    app.UseSwaggerUI();
}

// If you want Swagger always (even in production), you can do:
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();

// 5. Map Controllers
app.MapControllers();

app.Run();
