using Microsoft.Extensions.DependencyInjection;
using QueueSystem.Persistance.Jwt;

namespace QueueSystem.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            services.AddScoped<ITokenHandler, TokenHandler>();
        }
    }
}
