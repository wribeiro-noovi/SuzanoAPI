using Microsoft.AspNetCore.Mvc;
using SuzanoAPI.Repositories;
using SuzanoAPI.Request.Ani;

namespace SuzanoAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AniController : ControllerBase
    {
        private readonly SuzanoDbContext _context;
        public AniController(SuzanoDbContext context) => _context = context;

        [HttpPost("GetStatus")]
        public IActionResult GetStatus([FromBody] RequestBodyAniJson json)
        {
            var phone = _context.ani.FirstOrDefault(p => p.Phone == json.phone);
            if(phone is null) return NotFound();
            return Ok(phone.Status);
        }
    }
}
