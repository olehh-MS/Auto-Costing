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
        [Route("/GetLayers/{layerId}/{w}/{h}")]
        public IActionResult GetLayers(Guid layerId, int w, int h)
        {
            return Ok(_calculationsService.getLayers(layerId, w, h));
        }

        [HttpGet]
        [Route("/CreateTable/{layer}")]
        public IActionResult CreateTable(string layer)
        {
            return Ok(_calculationsService.buildTable(layer));
        }

        [HttpGet]
        [Route("/GetTables")]
        public IActionResult GetTable()
        {
            return Ok(_calculationsService.getTablesList());
        }

        [HttpGet]
        [Route("/GetWidthHeight")]
        public IActionResult getWidthHeight()
        {
            return Ok(_calculationsService.getWidthHeight());
        }
    }
}
