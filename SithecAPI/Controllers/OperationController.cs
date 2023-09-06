using Core.BusinessModels.Command;
using Core.ServiceInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SithecAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationController : ControllerBase
    {

        private readonly IOperationService _operationService;

        public OperationController(IOperationService operationService)
        {
            _operationService = operationService;
        }

        [HttpGet]
        public IActionResult MakeOperationWithGet([FromHeader] string num1, [FromHeader] string num2, [FromHeader] char operatorSymbol)
        {
            var result = _operationService.MakeOperation(double.Parse(num1), double.Parse(num2), operatorSymbol);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult MakeOperationWithPost([FromBody] OperationCommand request)
        {
            var result = _operationService.MakeOperation(request.num1, request.num2, request.operationSymbol);
            return Ok(result);
        }
    }
}
