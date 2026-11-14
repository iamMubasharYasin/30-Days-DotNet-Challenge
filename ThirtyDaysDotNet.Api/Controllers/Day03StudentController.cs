
using Microsoft.AspNetCore.Mvc;
using ThirtyDaysDotNet.Api.Models;

namespace ThirtyDaysDotNet.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Day03StudentController : ControllerBase
    {
        [HttpPost]
        public IActionResult RegisterStudent([FromBody] Student student)
        {
            return Ok(student);
        }


        [HttpGet("{id}")]
        public IActionResult GetStudentById([FromRoute] int id)
        {
            return Ok(new
            {
                Message = "Student ID received successfully",
                StudentId = id
            });
        }


        [HttpGet("search")]
        public IActionResult SearchStudent(
            [FromQuery] string name,
            [FromQuery] int age)
        {
            return Ok(new
            {
                Message = "Search parameters received",
                StudentName = name,
                StudentAge = age
            });
        }

    }

}
