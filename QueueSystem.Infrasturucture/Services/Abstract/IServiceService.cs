using QueueSystem.Domain.Entities;
using QueueSystem.Infrasturucture.DTOs;
using QueueSystem.Infrasturucture.DTOs.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueSystem.Infrasturucture.Services.Abstract
{
    public interface IServiceService
    {
        Task<List<ServiceDTO>> GetServices();
        Task AddService(ServiceDTO service);
    }
}
