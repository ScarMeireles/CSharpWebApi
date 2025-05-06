using Microsoft.AspNetCore.Mvc;

namespace CSharpWEBAPI.Controllers
{
    [ApiController]
    [Route("login")]
    public class LoginController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetLogin()
        {
            return Ok("Endpoint de login ativo");
        }
    }
}
