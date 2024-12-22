using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthJWTExample.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIController : ControllerBase
    {
        protected ActionResult CustomResponse(int status, bool sucess, object data = null)
        {
            return (status, sucess) switch
            {
                (200, true) => Ok(new BaseResponse { StatusCode = status, Sucess = sucess, Data = data }),
                (201, true) => Ok(new BaseResponse { StatusCode = status, Sucess = sucess, Data = data }),
                (204, true) => Ok(new BaseResponse { StatusCode = status, Sucess = sucess, Data = data }),
                (400, false) => BadRequest(new BaseResponse { StatusCode = status, Sucess = sucess, Data = data }),
                (401, false) => Unauthorized(new BaseResponse { StatusCode = status, Sucess = sucess, Data = data }),
                (404, false) => NotFound(new BaseResponse { StatusCode = status, Sucess = sucess, Data = data })
            };
        }
    }
}
