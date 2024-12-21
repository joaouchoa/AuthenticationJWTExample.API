using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthJWTExample.Application.DTOs.Response
{
    public record LoginResponse(
        bool sucess,
        string Token
    );
}
