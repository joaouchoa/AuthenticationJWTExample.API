using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthJWTExample.Application.DTOs.Request
{
    public record LoginRequest(
        string UserName,
        string Password
    );

}
