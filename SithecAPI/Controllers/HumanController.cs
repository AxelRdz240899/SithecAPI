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
        public IActionResult GetHumans()
        {
            return Ok(_humanRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetHumanById(int id)
        {
            return Ok(_humanRepository.GetHumanById(id));
        }

        [HttpPost]
        public IActionResult CreateHuman([FromBody] HumanCommand request)
        {
            request.Validate();
            var newHuman = _humanRepository.CreateHuman(request);
            return StatusCode(StatusCodes.Status201Created, newHuman);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateHuman([FromBody] HumanCommand request, int id)
        {
            request.Validate();
            var updatedHuman = _humanRepository.UpdateHuman(request, id);
            return Ok(updatedHuman);
        }
    }
}
