using Core.BusinessModels.Command;
using Microsoft.AspNetCore.Mvc;

namespace SithecAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HumanController : ControllerBase
    {

        [HttpGet("get-mock-humans")]
        public IActionResult GetMockHumanList()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetHumans()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetHumanById()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"{ex.Message}");
            }
        }

        [HttpPost]
        public IActionResult CreateHuman([FromBody] HumanCommand request)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"{ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateHuman([FromBody] HumanCommand request)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"{ex.Message}");
            }
        }
    }
}
