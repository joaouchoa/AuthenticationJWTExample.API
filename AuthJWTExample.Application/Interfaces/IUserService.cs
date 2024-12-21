using AuthJWTExample.Application.DTOs.Request;
using AuthJWTExample.Application.DTOs.Response;
using AuthJWTExample.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthJWTExample.Application.Interfaces
{
    public interface IUserService
    {
        public Task<AddUserResponse> Add(AddUserRequest user);
        public void GetUserByName(string userName);
    }
}
