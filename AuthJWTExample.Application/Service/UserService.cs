using AuthJWTExample.Application.DTOs.Request;
using AuthJWTExample.Application.DTOs.Response;
using AuthJWTExample.Application.Interfaces;
using AuthJWTExample.Application.Validators;
using AuthJWTExample.Application.Validators.Users;
using AuthJWTExample.Domain.Interfaces;
using AuthJWTExample.Domain.Model;

namespace AuthJWTExample.Application.Service
{
    public class UserService : IUserService
    {
        private readonly IPasswordHasher _passwordHasher;
        private readonly IUserRepository _userRepository;
        private readonly AddUserValidator _valitador;

        public UserService(IPasswordHasher passwordHasher, IUserRepository repository, AddUserValidator valitador)
        {
            _passwordHasher = passwordHasher;
            _userRepository = repository;
            _valitador = valitador;
        }

        public async Task<AddUserResponse> Add(AddUserRequest userRequest)
        {
            var validatorResult = _valitador.Validate(userRequest);

            if (!validatorResult.IsValid)
                return new AddUserResponse(validatorResult.IsValid, 
                    validatorResult.Errors.Select(e => e.ErrorMessage).ToList());

            var userDB = await _userRepository.GetUserByNameAsync(userRequest.UserName);

            if (userDB != null)
                return new AddUserResponse(false, new List<string> { ValidationMessages.USERNAME_ALREADY_EXISTS});

            var hashedPassword = _passwordHasher.HashPassword(userRequest.Password);

            var user = new User
            {
                UserName = userRequest.UserName,
                Password = hashedPassword,
                Role = userRequest.Role
            };

            var sucess = await _userRepository.AddUserAsync(user);

            if (!sucess)
                return new AddUserResponse(sucess, new List<string> { ValidationMessages.SERVICE_UNAVAILABLE });

            return new AddUserResponse(sucess, default);
        }

        public void GetUserByName(string user)
        {
            _userRepository.GetUserByNameAsync(user);
        }
    }
}
