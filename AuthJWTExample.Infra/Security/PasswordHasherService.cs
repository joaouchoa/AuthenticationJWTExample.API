using AuthJWTExample.Domain.Interfaces;
using AuthJWTExample.Domain.Model;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthJWTExample.Infra.Security
{
    public class PasswordHasherService : IPasswordHasher
    {
        private readonly PasswordHasher<object> _passwordHasher;

        public PasswordHasherService()
        {
            _passwordHasher = new PasswordHasher<object>();
        }

        public string HashPassword(string password)
        {
            return _passwordHasher.HashPassword(default, password);
        }

        public bool VerifyPassword(string hashedPassword, string plainPassword)
        {
            var result = _passwordHasher.VerifyHashedPassword(default, hashedPassword, plainPassword);
            return result == PasswordVerificationResult.Success;
        }
    }
}
