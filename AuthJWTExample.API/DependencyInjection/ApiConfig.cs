using AuthJWTExample.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace AuthJWTExample.API.DependencyInjection
{
    public static class ApiConfig
    {
        public static IServiceCollection AddApiConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAPIServices();
            services.AddDbContext<AuthJWTExampleContext>(options =>
                options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}
