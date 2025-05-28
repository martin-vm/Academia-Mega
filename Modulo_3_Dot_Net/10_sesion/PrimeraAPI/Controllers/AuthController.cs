using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using PrimeraAPI.Data;
using PrimeraAPI.Models;

namespace PrimeraAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly UsuarioService _usuarioService;
        private readonly IConfiguration _config;

        public AuthController(UsuarioService usuarioService, IConfiguration config)
        {
            _usuarioService = usuarioService;
            _config = config;

        }

        // POST /api/registro
        [HttpPost("Registro")]
        public async Task<IActionResult> Register(UserLogin user)
        {
            var ok = await _usuarioService.RegistroAsync(user.UserName, user.Password);

            if (!ok)
                return Conflict(new { message = "El usuario ya existe" });

            var token = GenerateToken(user.UserName);

            return Ok(new { token });
            
        }

        private string GenerateToken(string username)
        {
            var key = Encoding.ASCII.GetBytes(_config["JwtKey"]!);
            var claims = new[] {
                new Claim(ClaimTypes.Name, username)
            };

            var credentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256);

            var jwt = new JwtSecurityToken(                
                claims: claims,
                expires: DateTime.UtcNow.AddHours(2),
                signingCredentials: credentials                
            );

            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }
    }

    public class UserLogin
    { 
        public string UserName { get; set; } = "";
        public string Password { get; set; } = "";
    }



}

