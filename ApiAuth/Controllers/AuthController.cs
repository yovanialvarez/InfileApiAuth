using ApiAuth.Interface;
using ApiAuth.Models.Authentication;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService ServiceAuth;
        public AuthController(IAuthService serviceAuth)
        {
            this.ServiceAuth = serviceAuth;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] UserValidationRequest userRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new UserValidationResponse()
                {
                    Success = false,
                    Message = "Error Validar usuario y contraseña",
                    Data = new LoginResponse()
                });
            }

            UserValidationResponse result = await this.ServiceAuth.IsUserActive(userRequest);

            return Ok(new UserValidationResponse()
            {
                Success = result.Success,
                Message = result.Message,
                Data = result.Data
            });
        }
    }
}
