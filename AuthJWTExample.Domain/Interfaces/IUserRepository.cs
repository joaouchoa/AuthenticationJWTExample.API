using AuthJWTExample.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthJWTExample.Domain.Interfaces
{
    public interface IUserRepository
    {
        public Task AddUserAsync(User user);
        public Task<User> GetUserByNameAsync(string userName);
    }
}
