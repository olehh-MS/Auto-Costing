using Auto_Costing.Services;
using Microsoft.AspNetCore.Mvc;

namespace Auto_Costing.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LayersController : ControllerBase
    {
        private readonly ILayersService _layersService;

        public LayersController(ILayersService layersService)
        {
            _layersService = layersService;
        }

        [HttpGet]
        [Route("/BuildTable")]
        public IActionResult BuildTable(Guid layerId)
        {
            return Ok(_layersService.BuildTable(layerId));
        }

        [HttpGet]
        [Route("/GetTablesList")]
        public IActionResult GetTablesList()
        {
            return Ok(_layersService.GetTablesList());
        }

        [HttpGet]
        [Route("/GetLayers")]
        public IActionResult GetLayers(Guid layerId)
        {
            return Ok(_layersService.GetLayers(layerId));
        }
    }
}
