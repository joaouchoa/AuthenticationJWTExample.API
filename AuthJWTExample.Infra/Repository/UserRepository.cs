using AuthJWTExample.Domain.Interfaces;
using AuthJWTExample.Domain.Model;
using AuthJWTExample.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthJWTExample.Infra.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AuthJWTExampleContext _context;

        public UserRepository(AuthJWTExampleContext context)
        {
            _context = context;
        }

        public async Task<bool> AddUserAsync(User user)
        {
            try
            {
                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false; 
            }
        }

        public async Task<User> GetUserByNameAsync(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentException("Username cannot be null or empty.", nameof(username));
            }

            return await _context.Users
                .FirstOrDefaultAsync(u => u.UserName == username);
        }
    }
}
