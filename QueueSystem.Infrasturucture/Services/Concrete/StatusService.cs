using AutoMapper;
using Microsoft.EntityFrameworkCore;
using QueueSystem.Application.Repositories.Abstract;
using QueueSystem.Domain.Entities;
using QueueSystem.Infrasturucture.DTOs.Queue;
using QueueSystem.Infrasturucture.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueSystem.Infrasturucture.Services.Concrete
{
    public class StatusService(IMapper mapper, IGenericRepository<Queue> repository) : IStatusService
    {
        public async Task<List<GetQueueDTO>> GetQueueByStatus(int status)
        {
            var queuesItems = await repository.Where(x => x.Status.Id == status).ToListAsync();
            return mapper.Map<List<GetQueueDTO>>(queuesItems);
        }
    }
}
