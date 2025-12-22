using QueueSystem.Infrasturucture.DTOs.User;
using QueueSystem.Persistance.Jwt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueSystem.Infrasturucture.Services.UserService
{
    public interface IUserService
    {
        Task<bool> CreateUser(CreateUserDTO createUserDTO);
        Task<Token> SignIn(LoginDTO loginDTO);
    }
}
