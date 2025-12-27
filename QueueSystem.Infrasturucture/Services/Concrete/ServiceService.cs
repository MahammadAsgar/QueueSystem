using AutoMapper;
using QueueSystem.Application.Repositories.Abstract;
using QueueSystem.Application.UnitOfWorks;
using QueueSystem.Domain.Entities;
using QueueSystem.Infrasturucture.DTOs;
using QueueSystem.Infrasturucture.Services.Abstract;

namespace QueueSystem.Infrasturucture.Services.Concrete
{
    public class ServiceService(IMapper mapper, IGenericRepository<Service> repository, IUnitOfWork unitOfWork) : IServiceService
    {
        public async Task AddService(ServiceDTO serviceDTO)
        {
            var item = mapper.Map<Service>(serviceDTO);
            await repository.AddAsync(item);
            await unitOfWork.CommitAsync();
        }

        public async Task<List<ServiceDTO>> GetServices()
        {
            var items = await repository.GetAll();
            return mapper.Map<List<ServiceDTO>>(items);
        }
    }
}
