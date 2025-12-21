using QueueSystem.Infrasturucture.DTOs.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueSystem.Infrasturucture.Services.Abstract
{
    public interface IStatusService
    {
        Task<List<GetQueueDTO>> GetQueueByStatus(int status);
    }
}
