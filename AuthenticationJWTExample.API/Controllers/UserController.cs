using AuthJWTExample.Application.DTOs.Request;
using AuthJWTExample.Application.Interfaces;
using AuthJWTExample.Domain.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AuthJWTExample.API.Controllers
{
    [Authorize(Roles = "Manager")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : APIController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost(template: "add-user", Name = "add-user")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> AddUser(AddUserRequest user) 
        { 
            var result = await _userService.Add(user);

            if(!result.created)
                return CustomResponse((int)HttpStatusCode.BadRequest, result.created, result.Errors);

            return CustomResponse((int)HttpStatusCode.OK, result.created, result.Errors);
        }
    }
}
