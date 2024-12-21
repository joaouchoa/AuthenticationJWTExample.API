using AuthJWTExample.Application.Interfaces;
using AuthJWTExample.Domain.Interfaces;
using AuthJWTExample.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthJWTExample.Application.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository repository)
        {
            _userRepository = repository;
        }

        public void Add(User user)
        {
            _userRepository.AddUserAsync(user);
        }

        public void GetUserByName(string user)
        {
            _userRepository.GetUserByNameAsync(user);
        }
    }
}
