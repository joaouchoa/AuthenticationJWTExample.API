using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AuthJWTExample.Infra.Context
{
    public class AuthJWTExampleContextFactory : IDesignTimeDbContextFactory<AuthJWTExampleContext>
    {
        public AuthJWTExampleContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AuthJWTExampleContext>();
            optionsBuilder.UseSqlite("Data Source=../AuthJWTExample.Infra/AuthExample.db");

            return new AuthJWTExampleContext(optionsBuilder.Options);
        }
    }
}
