using AuthJWTExample.Application.DTOs.Request;
using AuthJWTExample.Application.Interfaces;
using AuthJWTExample.Domain.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthJWTExample.API.Controllers
{
    [Authorize(Roles = "Manager")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost(template: "add-user", Name = "add-user")]
        [ProducesResponseType(statusCode: StatusCodes.Status200OK)]
        [ProducesResponseType(statusCode: StatusCodes.Status500InternalServerError)]
        public ActionResult AddUser(AddUserRequest user) 
        { 
            _userService.Add(user);
            return Ok("User Insertd sucessfully");
        }

    }
}
