// File: Program.cs
using MedisyncAPI.Data;
using MedisyncAPI.Repositories.Classes;
using MedisyncAPI.Repositories.Interfaces;
using MedisyncAPI.Services; // Add this
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// 1. Register the DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2. Add controller support
builder.Services.AddControllers();

// 3. Register Repositories
builder.Services.AddScoped<IMedicationRepository, MedicationRepository>();
builder.Services.AddScoped<IInteractionRepository, InteractionRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

// 4. Register Services
builder.Services.AddScoped<IPasswordHasher, PasswordHasherService>(); // Register PasswordHasherService

// 5. Enable Swagger Services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 6. Add Logging
builder.Services.AddLogging();

// 7. Configure CORS
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

// 8. Configure JWT Authentication
var jwtSettings = builder.Configuration.GetSection("JwtSettings");
var secretKey = jwtSettings["SecretKey"];

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        // Validate the JWT Issuer (iss claim)
        ValidateIssuer = true,
        ValidIssuer = jwtSettings["Issuer"],

        // Validate the JWT Audience (aud claim)
        ValidateAudience = true,
        ValidAudience = jwtSettings["Audience"],

        // Validate the token expiry
        ValidateLifetime = true,

        // Validate the signing key
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)),

        // Optional: Set clock skew to zero for stricter expiration
        ClockSkew = TimeSpan.Zero
    };
});

// 9. Add Authorization Services
builder.Services.AddAuthorization();

var app = builder.Build();

// 10. Apply CORS Middleware Early
app.UseCors("AllowAngularApp");

// 11. Configure Swagger Only in Development
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

// 12. Use HTTPS Redirection
app.UseHttpsRedirection();

// 13. Use Authentication Middleware
app.UseAuthentication();

// 14. Use Authorization Middleware
app.UseAuthorization();

// 15. Map Controllers
app.MapControllers();

app.Run();
