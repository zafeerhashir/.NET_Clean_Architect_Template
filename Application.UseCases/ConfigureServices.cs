using Microsoft.Extensions.DependencyInjection;


namespace Application.UseCases
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInjectionApplication(this IServiceCollection services)
        {   // This is Mediate R it is used for CQRS in .NET This will take care of di of commands and queries
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            return services;
        }
    }
}
