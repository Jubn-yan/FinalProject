using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using FinalProject.Data;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ILogger<CourseController> _logger;
        private readonly CourseContext _ctx;

        public CourseController(ILogger<CourseController> logger, CourseContext ctx)
        {
            _logger = logger;
            _ctx = ctx;
        }
        [HttpGet]
        [ApiConventionMethod(typeof(DefaultApiConventions),
            nameof(DefaultApiConventions.Get))]
        public IActionResult Get(int? id)
        {
            if (id == null || id < 1)
                return Ok(_ctx.Courses.Take(5).ToList());
            
            var member = _ctx.Courses.Find(id);
            if (member == null)
                return NotFound();

            return Ok(member);
        }

        [HttpPut]
        [ApiConventionMethod(typeof(DefaultApiConventions),
            nameof(DefaultApiConventions.Put))]
        public IActionResult Put(Course course)
        {
            if (course.Id == null || course.Id < 1)
                return BadRequest("Invalid Member ID.");

            var dbInfo = _ctx.Courses.Find(course.Id);

            if (dbInfo == null)
                return NotFound();

            dbInfo.FullName = course.FullName;
            dbInfo.CourseID = course.CourseID;
            dbInfo.CourseName = course.CourseName;
            dbInfo.ProfessorName = course.ProfessorName;
            _ctx.Courses.Update(dbInfo);
            var changes = _ctx.SaveChanges();

            if (changes > 0)
                return NoContent();

            
            return StatusCode(500, "Error occured on the server. Please try again in a few minutes.");
        }

        [HttpPost]
        [ApiConventionMethod(typeof(DefaultApiConventions),
            nameof(DefaultApiConventions.Post))]
        public IActionResult Post(Course course)
        {
            if (string.IsNullOrEmpty(course.FullName))
            {
                return BadRequest("Must include the member's full name.");
            }
            if (string.IsNullOrEmpty(course.CourseID))
            {
                return BadRequest("Must include a the course ID.");
            }
            if (string.IsNullOrEmpty(course.CourseName))
            {
                return BadRequest("Must include the course name.");
            }
            if (string.IsNullOrEmpty(course.ProfessorName))
            {
                return BadRequest("Must include the professor's name.");
            }

            course.Id = null;
            _ctx.Courses.Add(course);
            var changes = _ctx.SaveChanges();
            if (changes > 0)
                return NoContent();
            
            return StatusCode(500, "Please try again later.");
        }

        [HttpDelete]
        [ApiConventionMethod(typeof(DefaultApiConventions),
            nameof(DefaultApiConventions.Delete))]
        public IActionResult Delete(int? id)
        {
            if (id == null || id < 1)
                return BadRequest("Invalid member ID.");

            var member = _ctx.Courses.Find(id);
            if (member == null)
                return NotFound();

            _ctx.Courses.Remove(member);
            var changes = _ctx.SaveChanges();
            if (changes > 0)
                return NoContent();
        
            return StatusCode(500, "Please try again later.");
        }
    }
}