using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZWalks.API.Controllers
{
    // https://localholst/api/students
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        // Get students
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] studentNames = new string[] { "John", "Jane", "Mark", "Emily", "David" };

            return Ok(studentNames);
        }
    }
}
