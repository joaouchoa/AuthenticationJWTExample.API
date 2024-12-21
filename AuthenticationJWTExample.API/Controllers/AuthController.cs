using AuthJWTExample.Application.DTOs.Request;
using AuthJWTExample.Application.Interfaces;
using AuthJWTExample.Domain.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthJWTExample.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : APIController
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost(template: "login", Name = "login")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> AddUser(LoginRequest request)
        {
            var token = await _authService.GenerateToken(request);

            if (token == String.Empty) 
                return Unauthorized();

            return Ok(token);
        }
    }
}
