using Microsoft.AspNetCore.Mvc;

namespace API1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok("Hello World");
        }
    }
}
