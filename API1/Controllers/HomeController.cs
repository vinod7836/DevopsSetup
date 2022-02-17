using Microsoft.AspNetCore.Mvc;

namespace API1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello Team");
        }
        [HttpGet]
        [Route("HostName")]
        public IActionResult HostName()
        {
            return Ok(Request.Host.Host);
        }
    }
}
