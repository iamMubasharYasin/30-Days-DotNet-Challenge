
using Microsoft.AspNetCore.Mvc;

namespace ThirtyDaysDotNet.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok("Welcome to Student API");
        }

        [HttpGet("details")]
        public IActionResult GetStudentDetails()
        {
            return Ok(new
            {
                Id = 1,
                Name = "Ali",
                Course = "Computer Science",
                Semester = 4
            });
        }

        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            return Ok($"Student ID: {id}");
        }


        [HttpGet("search")]
        public IActionResult SearchStudent([FromQuery] string name)
        {
            return Ok($"Searching student: {name}");
        }

        [HttpGet("semester/{semester}")]
        public IActionResult GetStudentsBySemester(
            [FromRoute] int semester)
        {
            return Ok($"Students in semester: {semester}");
        }


        [HttpGet("profile/{id}")]
        public IActionResult GetStudentProfile(
            [FromRoute] int id,
            [FromQuery] string name)
        {
            return Ok(new
            {
                StudentId = id,
                StudentName = name,
                Message = "Student profile fetched successfully"
            });
        }


    }
}
