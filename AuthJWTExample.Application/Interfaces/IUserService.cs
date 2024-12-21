using AuthJWTExample.Application.DTOs.Request;
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
        public void Add(AddUserRequest user);
        public void GetUserByName(string userName);
    }
}
