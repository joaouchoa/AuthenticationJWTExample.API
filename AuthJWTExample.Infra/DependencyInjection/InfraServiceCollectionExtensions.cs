using AuthJWTExample.Domain.Interfaces;
using AuthJWTExample.Infra.Repository;
using AuthJWTExample.Infra.Security;
using Microsoft.Extensions.DependencyInjection;


namespace AuthJWTExample.Infra.DependencyInjection
{
    public static class InfraServiceCollectionExtensions
    {
        public static IServiceCollection AddInfraServices(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IPasswordHasher, PasswordHasherService>();

            return services;
        }
    }
}
