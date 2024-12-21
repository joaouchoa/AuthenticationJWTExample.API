using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthJWTExample.Application.DTOs.Request
{
    public record AddUserRequest(
        string UserName,
        string Role,
        string Password
    );
}
