using Auto_Costing.Services;
using Microsoft.AspNetCore.Mvc;

namespace Auto_Costing.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculationsController : ControllerBase
    {
        private readonly ICalculationsService _calculationsService;

        public CalculationsController(ICalculationsService calculationsService)
        {
            _calculationsService = calculationsService;
        }

        [HttpGet]
        [Route("/CalculateFormula")]
        public IActionResult CalculateFormula(string formula, int w, int h)
        {
            return Ok();
        }
    }
}
