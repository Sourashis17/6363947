using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet("public")]
        public IActionResult Public() => Ok("This is a public endpoint.");

        [Authorize]
        [HttpGet("secure")]
        public IActionResult Secure() => Ok("This is a protected endpoint. You are authenticated!");
    }
}
