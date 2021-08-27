using Microsoft.AspNetCore.Mvc;

namespace Pokedex.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult Hi()
        {
            return Ok(new { Message = "Hey" });
        }
    }
}