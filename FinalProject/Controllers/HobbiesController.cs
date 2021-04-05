using FinalProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FinalProject.Data;

namespace FinalProject.Controllers
{
    [ApiController]
    [Route("[controller")]
    public class HobbiesController : ControllerBase
    {
        private readonly ILogger<HobbiesController> _logger;
        private readonly HobbyContext _ctx;
        public HobbiesController(ILogger<HobbiesController> logger, HobbyContext ctx)
        {
            _logger = logger;
            _ctx = ctx;
        }
        
    }
}