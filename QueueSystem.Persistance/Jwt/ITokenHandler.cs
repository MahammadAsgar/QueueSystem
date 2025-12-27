using QueueSystem.Domain.Entities.Users;

namespace QueueSystem.Persistance.Jwt
{
    public interface ITokenHandler
    {
        Task<Token> CreateAccessToken(AppUser user);
    }
}
