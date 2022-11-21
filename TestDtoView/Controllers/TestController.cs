using Microsoft.AspNetCore.Mvc;
using TestDtoView.Models;

namespace TestDtoView.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class TestController : Controller
    {
        [HttpPost("update")]
        public IActionResult Update([FromBody] UpdateDto updateDto)
        {
            var result = TestService.Update(updateDto);

            return Ok(result);
        }
    }
}
