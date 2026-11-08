using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ThirtyDaysDotNet.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMessage()
        {
            return Ok(new
            {
                Message = "Welcome to 30 Days .NET Challenge!",
                Day = 1,
                Framework = ".NET 10",
                Status = "Learning"
            });
        }
    }
}
