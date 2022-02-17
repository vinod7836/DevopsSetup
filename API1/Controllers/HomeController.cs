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
        [HttpGet]
        [Route("name/{name}")]
        public IActionResult Name(string name)
        {
            return Ok($"Hello {name}");
        }

        [HttpGet]
        [Route("age/{age}")]
        public IActionResult GetAge(string age)
        {
            return Ok($"Hello, your age is {age}");
        }
    }
}
