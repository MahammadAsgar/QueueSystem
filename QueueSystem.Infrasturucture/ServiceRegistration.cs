using Microsoft.Extensions.DependencyInjection;
using QueueSystem.Domain.Context;
using QueueSystem.Infrasturucture.Mapper;
using QueueSystem.Infrasturucture.Services.Abstract;
using QueueSystem.Infrasturucture.Services.Concrete;
using QueueSystem.Infrasturucture.Services.UserService;
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

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IServiceService, ServiceService>();
            services.AddAutoMapper(cfg =>
            {
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<MapProfile>();
            });
        }
    }
}
