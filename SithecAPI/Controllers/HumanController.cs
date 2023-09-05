using Core.BusinessModels.Command;
using Core.RepositoryInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace SithecAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HumanController : ControllerBase
    {
        private readonly IHumanRepository _humanRepository;

        public HumanController(IHumanRepository humanRepository) 
        {
            _humanRepository = humanRepository;
        }

        [HttpGet("mock-humans")]
        public IActionResult GetMockHumanList()
        {
            try
            {
                return Ok(_humanRepository.GetMockHumanList());
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
                return Ok(_humanRepository.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetHumanById(int id)
        {
            try
            {
                return Ok(_humanRepository.GetHumanById(id));
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
                request.Validate();
                var newHuman = _humanRepository.CreateHuman(request);
                return StatusCode(StatusCodes.Status201Created, newHuman);
            }
            catch (Exception ex)
            {
                return BadRequest($"{ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateHuman([FromBody] HumanCommand request, int id)
        {
            try
            {
                request.Validate();
                var updatedHuman = _humanRepository.UpdateHuman(request, id);
                return Ok(updatedHuman);
            }
            catch (Exception ex)
            {
                return BadRequest($"{ex.Message}");
            }
        }
    }
}
