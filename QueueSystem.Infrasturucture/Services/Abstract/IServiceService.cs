using QueueSystem.Infrasturucture.DTOs;

namespace QueueSystem.Infrasturucture.Services.Abstract
{
    public interface IServiceService
    {
        Task<List<ServiceDTO>> GetServices();
        Task AddService(ServiceDTO service);
    }
}
