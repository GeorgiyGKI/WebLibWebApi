using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Service.ServiceManager;
using Shared.DataTransferObject;

namespace WebLibWebApi.Controllers
{
    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IServiceManager _service;
        public AuthenticationController(IServiceManager service) => 
            _service = service;

        [HttpPost("login")]
        public async Task<IActionResult> Authenticate([FromBody] AuthorizeDto authorizeDto)
        {
            if (!await _service.AuthenticationService.ValidateAdmin(authorizeDto))
                return Unauthorized();

            return Ok(new
            {
                Token = await _service.AuthenticationService.CreateToken()
            });
        }
    
    }
}
