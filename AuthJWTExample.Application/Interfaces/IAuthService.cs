using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthJWTExample.Application.DTOs.Request;
using AuthJWTExample.Domain.Model;

namespace AuthJWTExample.Application.Interfaces
{
    public interface IAuthService
    {
        Task<string> GenerateToken(LoginRequest user);
    }
}
