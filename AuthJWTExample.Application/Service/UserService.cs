using AuthJWTExample.Application.DTOs.Request;
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
        private readonly IPasswordHasher _passwordHasher;
        private readonly IUserRepository _userRepository;

        public UserService(IPasswordHasher passwordHasher, IUserRepository repository)
        {
            _passwordHasher = passwordHasher;
            _userRepository = repository;
        }

        public void Add(AddUserRequest userRequest)
        {
            var hashedPassword = _passwordHasher.HashPassword(userRequest.Password);

            var user = new User
            {
                UserName = userRequest.UserName,
                Password = hashedPassword,
                Role = userRequest.Role
            };

            _userRepository.AddUserAsync(user);
        }

        public void GetUserByName(string user)
        {
            _userRepository.GetUserByNameAsync(user);
        }
    }
}
