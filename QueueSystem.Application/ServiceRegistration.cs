using Microsoft.Extensions.DependencyInjection;
using QueueSystem.Application.Repositories.Abstract;
using QueueSystem.Application.Repositories.Concrete;
using QueueSystem.Application.UnitOfWorks;
using QueueSystem.Domain.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueSystem.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
