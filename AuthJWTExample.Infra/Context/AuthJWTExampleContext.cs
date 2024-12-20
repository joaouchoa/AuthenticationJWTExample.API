using AuthJWTExample.Domain.Model;
using AuthJWTExample.Infra.Config;
using Microsoft.EntityFrameworkCore;

namespace AuthJWTExample.Infra.Context
{
    public class AuthJWTExampleContext : DbContext
    {
        public AuthJWTExampleContext()
        {
            
        }

        public AuthJWTExampleContext(DbContextOptions<AuthJWTExampleContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
