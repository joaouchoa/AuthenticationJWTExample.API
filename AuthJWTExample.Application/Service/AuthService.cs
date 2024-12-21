using AuthJWTExample.Application.DTOs.Request;
using AuthJWTExample.Application.Interfaces;
using AuthJWTExample.Domain.Interfaces;
using AuthJWTExample.Domain.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AuthJWTExample.Application.Service
{
    public class AuthService : IAuthService
    {
        private readonly IConfiguration _configuration;
        private readonly IUserRepository _userRepository;

        public AuthService(IConfiguration configuration, IUserRepository userRepository)
        {
            _configuration = configuration;
            _userRepository = userRepository;
        }
        public async Task<string> GenerateToken(LoginRequest user)
        {
            var userFromDb = await _userRepository.GetUserByNameAsync(user.UserName);

            if(userFromDb == null)
                return String.Empty;

            if ( user.UserName != userFromDb.UserName || user.Password != userFromDb.Password)
                return String.Empty;

            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

            var issue = _configuration["Jwt:Issuer"];
            var audience = _configuration["Jwt:Audience"];

            var signinCredential = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            var tokenOption = new JwtSecurityToken(
                issuer: issue,
                audience: audience,
                claims: new[]
                {
                    new Claim(type: ClaimTypes.Name, userFromDb.UserName),
                    new Claim(type: ClaimTypes.Role, userFromDb.Role),
                },
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: signinCredential
            );

            var token = new JwtSecurityTokenHandler().WriteToken(tokenOption);

            return token;
        }
    }
}
