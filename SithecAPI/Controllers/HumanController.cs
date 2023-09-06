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
            return Ok(_humanRepository.GetMockHumanList());
        }

        [HttpGet]
        public async Task<IActionResult> GetHumans()
        {
            return Ok(await _humanRepository.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetHumanById(int id)
        {
            return Ok(await _humanRepository.GetHumanByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateHuman([FromBody] HumanCommand request)
        {
            request.Validate();
            var newHuman = await _humanRepository.CreateHumanAsync(request);
            return StatusCode(StatusCodes.Status201Created, newHuman);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateHuman([FromBody] HumanCommand request, int id)
        {
            request.Validate();
            var updatedHuman = await _humanRepository.UpdateHumanAsync(request, id);
            return Ok(updatedHuman);
        }
    }
}
