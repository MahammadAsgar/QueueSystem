using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QueueSystem.Domain.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
