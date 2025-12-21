using QueueSystem.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueSystem.Persistance.Jwt
{
    public interface ITokenHandler
    {
        Task<Token> CreateAccessToken(AppUser user);
    }
}
