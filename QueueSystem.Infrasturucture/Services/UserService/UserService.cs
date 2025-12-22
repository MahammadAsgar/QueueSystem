using AutoMapper;
using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using QueueSystem.Application.Repositories.Abstract;
using QueueSystem.Domain.Entities;
using QueueSystem.Domain.Entities.Users;
using QueueSystem.Infrasturucture.DTOs.User;
using QueueSystem.Persistance.Jwt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueSystem.Infrasturucture.Services.UserService
{
    public class UserService(IMapper mapper, UserManager<AppUser> userManager, IHttpContextAccessor httpContextAccessor,
        SignInManager<AppUser> signInManager, ITokenHandler tokenHandler, IGenericRepository<Service> serviceRepository) : IUserService
    {
        #region Auth
        public async Task<bool> CreateUser(CreateUserDTO createUserDTO)
        {
            AppUser user = mapper.Map<AppUser>(createUserDTO);
            bool isUser = !string.IsNullOrEmpty(createUserDTO.Password);

            var result = isUser
                ? await userManager.CreateAsync(user, createUserDTO.Password)
                : await userManager.CreateAsync(user);
            if (result.Succeeded)
            {

                var response = await Activate(isUser, createUserDTO.UserName);
                return response;
            }
            return false;
        }
        private async Task<bool> Activate(bool isUser, string userName)
        {
            var user = await userManager.FindByNameAsync(userName);
            if (user != null)
            {
                user.EmailConfirmed = true;
                await (isUser
                    ? userManager.AddToRoleAsync(user, "User")
                    : userManager.AddToRoleAsync(user, "Customer"));

                await userManager.UpdateAsync(user);
                return true;
            }
            return false;
        }
        public async Task<Token> SignIn(LoginDTO loginDTO)
        {
            var user = await userManager.FindByNameAsync(loginDTO.UserName);
            if (user != null)
            {
                var response = signInManager.CheckPasswordSignInAsync(user, loginDTO.Password, false);
                if (response.IsCompletedSuccessfully)
                {
                    Token token = await tokenHandler.CreateAccessToken(user);
                    return token;
                }
            }
            return new Token();
        }
        #endregion

        #region User
        //public async Task<GetUserDTO> AddServicesToUser(List<int> idsService, string userName)
        //{
        //    var items = await serviceRepository.Where(x => idsService.Contains(x.Id)).ToListAsync();
        //    var user = await userManager.FindByNameAsync(userName);
        //    if (user != null)
        //    {
        //        user.
        //    }
        //}

        #endregion
    }
}
