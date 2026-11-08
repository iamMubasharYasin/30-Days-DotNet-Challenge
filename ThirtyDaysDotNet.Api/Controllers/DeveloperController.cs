using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace ThirtyDaysDotNet.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperController : ControllerBase
    {
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
