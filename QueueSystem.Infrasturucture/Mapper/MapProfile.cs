using AutoMapper;
using QueueSystem.Domain.Entities;
using QueueSystem.Domain.Entities.Users;
using QueueSystem.Infrasturucture.DTOs;
using QueueSystem.Infrasturucture.DTOs.Queue;
using QueueSystem.Infrasturucture.DTOs.User;

namespace QueueSystem.Infrasturucture.Mapper
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<StatusDTO, Status>().ReverseMap();
            CreateMap<PriorityDTO, Priority>().ReverseMap();
            CreateMap<ServiceDTO, Service>().ReverseMap();
            CreateMap<GetQueueDTO, Ticket>().ReverseMap();

            #region UserMapping
            CreateMap<AppUser, CreateUserDTO>().ReverseMap();
            CreateMap<AppUser, LoginDTO>().ReverseMap();
            #endregion
        }
    }
}
