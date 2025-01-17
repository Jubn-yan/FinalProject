using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using FinalProject.Data;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HobbiesController : ControllerBase
    {
        private readonly ILogger<HobbiesController> _logger;
        private readonly HobbyContext _ctx;
        public HobbiesController(ILogger<HobbiesController> logger, HobbyContext ctx)
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
            return Ok(_ctx.Hobbies.Take(5).ToList());
            
            var member = _ctx.Hobbies.Find(id);
        if (member == null)
            return NotFound();

        return Ok(member);
      }

      [HttpPut]
      [ApiConventionMethod(typeof(DefaultApiConventions),
            nameof(DefaultApiConventions.Put))]
      public IActionResult Put(Hobby hobby)
      {
            if (hobby.Id == null || hobby.Id < 1)
                return BadRequest("Invalid member Id");

            var dbInfo = _ctx.Hobbies.Find(hobby.Id);

            if (dbInfo == null)
                return NotFound();

            dbInfo.FullName = hobby.FullName;
            dbInfo.FavoriteHobby = hobby.FavoriteHobby;
            dbInfo.SecondFavoriteHobby = hobby.SecondFavoriteHobby;
            dbInfo.WhyYouLikeThem = hobby.WhyYouLikeThem;
            _ctx.Hobbies.Update(dbInfo);
            var changes = _ctx.SaveChanges();

            if (changes > 0)
                return NoContent();

            
            return StatusCode(500, "Error occured on the server. Please try again in a few minutes.");
      }

      [HttpPost]
      [ApiConventionMethod(typeof(DefaultApiConventions),
            nameof(DefaultApiConventions.Post))]
      public IActionResult Post(Hobby hobby)
      {
            if (string.IsNullOrEmpty(hobby.FullName))
            {
                return BadRequest("Must include a Full Name for the member.");
            }
            if (string.IsNullOrEmpty(hobby.FavoriteHobby))
            {
                return BadRequest("Must include a Favorite Hobby.");
            }
            if (string.IsNullOrEmpty(hobby.SecondFavoriteHobby))
            {
                return BadRequest("Must include a Second Favorite Hobby.");
            }
            if (string.IsNullOrEmpty(hobby.WhyYouLikeThem))
            {
                return BadRequest("Must include Why You Like Them.");
            }

            hobby.Id = null;
            _ctx.Hobbies.Add(hobby);
            var changes = _ctx.SaveChanges();
            if (changes > 0)
                return NoContent();
            
            return StatusCode(500, "Please try again later");
      }

      [HttpDelete]
      [ApiConventionMethod(typeof(DefaultApiConventions),
            nameof(DefaultApiConventions.Delete))]
      public IActionResult Delete(int? id, Hobby hobby)
      {
        if (id == null || id < 1)
            return BadRequest("Invalid member Id");

        var member = _ctx.Hobbies.Find(id);
        if (member == null)
            return NotFound();

        _ctx.Hobbies.Remove(member);
        var changes = _ctx.SaveChanges();

        if (changes > 0)
            return NoContent();
        
        return StatusCode(500, "Please try again later");
      }
        
    }
}