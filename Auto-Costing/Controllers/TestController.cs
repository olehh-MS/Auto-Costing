using Microsoft.AspNetCore.Mvc;
using System.Data;

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
            
            while(formula.Contains("[") || formula.Contains("]"))
            {
                string variable = formula.Substring(formula.IndexOf("["), formula.IndexOf("]") - formula.IndexOf("[") + 1);
                formula = formula.Replace(variable, GetValue(variable).ToString());
            }

            DataTable dt = new DataTable();
            var result = dt.Compute(formula, "");

            return Ok(result);
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
