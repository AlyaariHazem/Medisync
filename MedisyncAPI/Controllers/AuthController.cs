// File: Controllers/AuthController.cs
using MedisyncAPI.models;
using MedisyncAPI.Repositories.Interfaces;
using MedisyncAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MedisyncAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher _passwordHasher;

        public AuthController(
            IConfiguration configuration,
            IUserRepository userRepository,
            IPasswordHasher passwordHasher)
        {
            _configuration = configuration;
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel registerModel)
        {
            // Validate the incoming model
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // Check if the username is already taken
            var existingUser = await _userRepository.GetUserByUsernameAsync(registerModel.Username);
            if (existingUser != null)
                return Conflict(new { message = "Username is already taken." });

            // Hash the password
            var hashedPassword = _passwordHasher.HashPassword(registerModel.Password);

            // Create the user entity
            var user = new User
            {
                Username = registerModel.Username,
                PasswordHash = hashedPassword
                // Initialize other properties if any
            };

            // Save the user to the database
            await _userRepository.CreateUserAsync(user);

            // Generate JWT token
            var token = GenerateJwtToken(user);

            return Ok(new { Token = token });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel loginModel)
        {
            // Validate the incoming model
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // Retrieve the user from the database
            var user = await _userRepository.GetUserByUsernameAsync(loginModel.Username);
            if (user == null)
                return Unauthorized(new { message = "Invalid credentials." });

            // Verify the password
            var isPasswordValid = _passwordHasher.VerifyPassword(user.PasswordHash, loginModel.Password);
            if (!isPasswordValid)
                return Unauthorized(new { message = "Invalid credentials." });

            // Generate JWT token
            var token = GenerateJwtToken(user);

            return Ok(new { Token = token });
        }

        private string GenerateJwtToken(User user)
        {
            var jwtSettings = _configuration.GetSection("JwtSettings");
            var secretKey = jwtSettings["SecretKey"];
            var issuer = jwtSettings["Issuer"];
            var audience = jwtSettings["Audience"];
            var expiryInMinutes = Convert.ToDouble(jwtSettings["TokenExpiryInMinutes"]);

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            // Define claims
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Username),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                // Add additional claims if needed (e.g., roles)
            };

            // Create the token
            var token = new JwtSecurityToken(
                issuer: issuer,
                audience: audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(expiryInMinutes),
                signingCredentials: credentials
            );

            // Return the serialized token
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
