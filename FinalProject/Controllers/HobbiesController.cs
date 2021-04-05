using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using FinalProject.Data;

namespace FinalProject.Controllers
{
    [ApiController]
    [Route("[controller")]
    public class HobbiesController : ControllerBase
    {
        private readonly ILogger<HobbiesController> _logger;
        private readonly MemberContext _ctx;
        public HobbiesController(ILogger<HobbiesController> logger, MemberContext ctx)
        {
            _logger = logger;
            _ctx = ctx;
        }
        
    }
}