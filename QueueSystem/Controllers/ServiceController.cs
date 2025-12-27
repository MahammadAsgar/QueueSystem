using Microsoft.AspNetCore.Mvc;
using QueueSystem.Infrasturucture.DTOs;
using QueueSystem.Infrasturucture.Services.Abstract;

namespace QueueSystem.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ServiceController(IServiceService serviceService) : ControllerBase
    {

        [HttpPost]
        public async Task<ActionResult> AddService(ServiceDTO serviceDTO)
        {
            await serviceService.AddService(serviceDTO);
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> GetServices()
        {
            return Ok(await serviceService.GetServices());
        }
    }
}
