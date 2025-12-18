using AutoMapper;
using QueueSystem.Domain.Entities;
using QueueSystem.Infrasturucture.DTOs;
using QueueSystem.Infrasturucture.DTOs.Customer;
using QueueSystem.Infrasturucture.DTOs.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueSystem.Infrasturucture.Mapper
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<StatusDTO, Status>().ReverseMap();
            CreateMap<PriorityDTO, Priority>().ReverseMap();
            CreateMap<WorkerDTO, Worker>().ReverseMap();
            CreateMap<ServiceDTO, Service>().ReverseMap();
            CreateMap<AddCustomerDTO, Customer>().ReverseMap();
            CreateMap<GetCustomerDTO, Customer>().ReverseMap();
            CreateMap<GetQueueDTO, Queue>().ReverseMap();
        }
    }
}
