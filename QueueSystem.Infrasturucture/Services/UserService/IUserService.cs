using QueueSystem.Infrasturucture.DTOs.User;
using QueueSystem.Persistance.Jwt;

namespace QueueSystem.Infrasturucture.Services.UserService
{
    public interface IUserService
    {
        Task<bool> CreateUser(CreateUserDTO createUserDTO);
        Task<Token> SignIn(LoginDTO loginDTO);
    }
}
