using Persistence.Contexts;
using Persistence.Repositories;
using Application.Interface.Persistence;
using Microsoft.Extensions.DependencyInjection;


namespace Persistence
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInjectionPersistence(this IServiceCollection services)
        {  // your repos di will go here
            services.AddSingleton<DapperContext>();
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}