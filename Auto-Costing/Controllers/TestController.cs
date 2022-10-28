using Microsoft.AspNetCore.Mvc;

namespace Auto_Costing.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        [Route("/CalculateFormula/{formula}")]
        public IActionResult CalculateFormula(string formula)
        {
            string testFormula = "[value1] * ([value2] + [value3])";



            return Ok();
        }

        private decimal GetValue(string value)
        {
            switch (value)
            {
                case "[value1]":
                    return 12;
                case "[value2]":
                    return 5;
                case "[value3]":
                    return 2;
                default:
                    return 0;
            }
        }
    }
}
