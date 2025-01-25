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

// 3. Register Repositories
builder.Services.AddScoped<IMedicationRepository, MedicationRepository>();
builder.Services.AddScoped<IInteractionRepository, InteractionRepository>();

// 4. Enable Swagger Services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 5. Add Logging
builder.Services.AddLogging();

// 6. Configure CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularApp",
        policyBuilder =>
        {
            policyBuilder
                .WithOrigins("http://localhost:4200", "https://localhost:4200") // Include both HTTP and HTTPS
                .AllowAnyMethod()
                .AllowAnyHeader();
        });
});

var app = builder.Build();

// 7. Apply CORS Middleware Early
app.UseCors("AllowAngularApp");

// 8. Configure Swagger Only in Development
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

// 9. Use HTTPS Redirection
app.UseHttpsRedirection();

// 10. Use Authorization Middleware
app.UseAuthorization();

// 11. Map Controllers
app.MapControllers();

app.Run();
