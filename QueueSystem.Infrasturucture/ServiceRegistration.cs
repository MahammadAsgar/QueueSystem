using Microsoft.Extensions.DependencyInjection;
using QueueSystem.Domain.Context;
using QueueSystem.Infrasturucture.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueSystem.Infrasturucture
{
    public static class ServiceRegistration
    {
        public static void AddInfrastuructureServices(this IServiceCollection services)
        {
            services.AddAutoMapper(cfg =>
            {
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<MapProfile>();
            });
        }
    }
}
