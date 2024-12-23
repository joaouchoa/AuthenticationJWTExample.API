using AuthJWTExample.Application.DependencyInjection;
using AuthJWTExample.Application.Interfaces;
using AuthJWTExample.Application.Service;
using AuthJWTExample.Infra.DependencyInjection;
using FluentValidation;
using System.Reflection;

namespace AuthJWTExample.API.DependencyInjection
{
    public static class ApiServiceCollectionExtensions
    {
        public static IServiceCollection AddAPIServices(this IServiceCollection services)
        {
            services.AddAplicationServices();
            services.AddInfraServices();

            return services;
        }
    }
}
