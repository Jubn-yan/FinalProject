using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using FinalProject.Models;
using FinalProject.Data;

namespace FinalProject.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class MembersInfoController : ControllerBase
    {
      private readonly ILogger<MembersInfoController> _logger;
      private readonly MemberContext _ctx;
      
      public MembersInfoController(ILogger<MembersInfoController> logger, MemberContext ctx)
      {
        _logger = logger;
        _ctx = ctx;
      }
    }
}