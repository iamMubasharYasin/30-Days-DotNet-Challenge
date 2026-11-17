using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using ThirtyDaysDotNet.Api.Interfaces;

namespace ThirtyDaysDotNet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperController : ControllerBase
    {
        private readonly IDeveloperService _developerService;

        public DeveloperController(IDeveloperService developerService)
        {
            _developerService = developerService;
        }

        [HttpGet("lifetime")]
        public IActionResult CheckLifetime([FromServices] IDeveloperService service1,[FromServices] IDeveloperService service2)
        {
            return Ok(new
            {
                First = service1.GetInstanceId(),
                Second = service2.GetInstanceId()
            });
        }

        [HttpGet("name")]
        public IActionResult GetDeveloperName()
        {
            string name = _developerService.GetDeveloperName();

            return Ok(name);
        }

        [HttpGet("instance")]
        public IActionResult GetInstance()
        {
            return Ok(new
            {
                First = _developerService.GetInstanceId(),
                Second = _developerService.GetInstanceId()
            });
        }

        [HttpGet]
        public IActionResult Developer()
        {
            return Ok(new
            {
                name = "Mubashar Yasin",
                skill = ".NET Developer",
                challengeDay = 1,
                status= "Active"
            }
            );
        }

        [HttpGet("skills")]
        public IActionResult YourSkills()
        {
            return Ok(new
            {
                SkillOne="C#",
                SkillTwo="ASP.NET Core",
                SkillThree="SQL Server"
            });
        }

    }
}
