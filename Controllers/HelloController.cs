using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                message = "Hello from ASP.NET!",
                status = "running",
                builtBy = "DemoApp"
            });
        }
    }
}