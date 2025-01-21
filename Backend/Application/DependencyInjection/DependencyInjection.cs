using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // Register application-layer services
            // Example: services.AddTransient<IMyService, MyService>();
            return services;
        }
    }
}
