using Microsoft.AspNetCore.Mvc;
using QueueSystem.Infrasturucture.DTOs.User;
using QueueSystem.Infrasturucture.Services.UserService;

namespace QueueSystem.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController(IUserService userService) : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> CreateUser(CreateUserDTO createUserDTO)
        {
            return Ok(await userService.CreateUser(createUserDTO));
        }

        [HttpPost]
        public async Task<ActionResult> SignIn(LoginDTO loginDTO)
        {
            return Ok(await userService.SignIn(loginDTO));
        }
    }
}
