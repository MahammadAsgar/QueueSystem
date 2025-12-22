using AutoMapper;
using QueueSystem.Domain.Entities;
using QueueSystem.Domain.Entities.Users;
using QueueSystem.Infrasturucture.DTOs;
using QueueSystem.Infrasturucture.DTOs.Customer;
using QueueSystem.Infrasturucture.DTOs.Queue;
using QueueSystem.Infrasturucture.DTOs.User;
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
            CreateMap<ServiceDTO, Service>().ReverseMap();
            CreateMap<GetQueueDTO, QueueTicket>().ReverseMap();

            #region UserMapping
            CreateMap<AppUser, CreateUserDTO>().ReverseMap();
            CreateMap<AppUser, LoginDTO>().ReverseMap();
            #endregion
        }
    }
}
