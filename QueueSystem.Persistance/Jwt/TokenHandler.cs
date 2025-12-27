using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using QueueSystem.Domain.Entities.Users;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace QueueSystem.Persistance.Jwt
{
    public class TokenHandler(IConfiguration configuration, UserManager<AppUser> userManager) : ITokenHandler
    {
        public async Task<Token> CreateAccessToken(AppUser user)
        {
            Token token = new Token();
            SymmetricSecurityKey symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Token:SecurityKey"]));
            SigningCredentials signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);
            DateTime expireDate = DateTime.UtcNow.AddHours(Double.Parse(configuration["Token:ExpireDate"]));
            var claims = await SetClaims(user);
            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(
                audience: configuration["Token:Audience"],
                issuer: configuration["Token:Issure"],
                expires: expireDate,
                signingCredentials: signingCredentials,
                notBefore: DateTime.UtcNow,
                claims: claims
                );
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            token.AccessToken = tokenHandler.WriteToken(jwtSecurityToken);
            return token;
        }

        private async Task<IEnumerable<Claim>> SetClaims(AppUser user)
        {
            var roles = await userManager.GetRolesAsync(user);
            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, user.UserName),
            };
            claims.AddRange(roles.Select(x => new Claim(ClaimTypes.Role, x)));
            return claims;
        }
    }
}
