using AuthJWTExample.API.Constants;
using AuthJWTExample.Application.DTOs.Request;
using AuthJWTExample.Application.Interfaces;
using AuthJWTExample.Application.Validators;
using AuthJWTExample.Domain.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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
        public async Task<ActionResult> Login(LoginRequest request)
        {
            var token = await _authService.GenerateToken(request);

            if (token == String.Empty)
                return CustomResponse((int)HttpStatusCode.Unauthorized, false, ControllerMessages.AUTH_ERROR_001_INVALID_CREDENTIALS, default);

            return CustomResponse((int)HttpStatusCode.OK, true,ControllerMessages.AUTH_OK_001_LOGIN_SUCCESSFUL, token);
        }
    }
}
