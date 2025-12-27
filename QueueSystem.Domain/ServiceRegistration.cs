using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QueueSystem.Domain.Context;

namespace QueueSystem.Domain
{
    public static class ServiceRegistration
    {
        public static void AddDomainServices(this IServiceCollection services)
        {
            services.AddDbContext<QueueDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
        }
    }
}
