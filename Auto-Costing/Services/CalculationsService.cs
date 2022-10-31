using Auto_Costing.Models;
using System.Data;

namespace Auto_Costing.Services
{
    public class CalculationsService : ICalculationsService
    {
        public decimal CalculateStringFormula(string formula)
        {
            DataTable dt = new DataTable();
            var result = dt.Compute(formula, "");

            return Convert.ToDecimal(result);
        }

        // to del
        public decimal CalculateFormula(string formula, int param1Value, int param2Value)
        {
            formula = formula.Replace("[Param1Value]", param1Value.ToString());
            formula = formula.Replace("[Param2Value]", param2Value.ToString());

            while (formula.Contains("[") || formula.Contains("]"))
            {
                string code = formula.Substring(formula.IndexOf("["), formula.IndexOf("]") - formula.IndexOf("[") + 1);
                formula = formula.Replace(code, GetValue(code, param1Value, param2Value).ToString());
            }

            DataTable dt = new DataTable();
            var result = dt.Compute(formula, "");

            return Convert.ToDecimal(result);
        }

        private decimal GetValue(string code, int param1Value, int param2Value)
        {
            switch (code)
            {
                case "[L:N7]":
                case "[L:N7.DirectMats]":
                case "[L:N7.Labor]":
                case "[L:Pack]":
                    var layer = Db.layers.FirstOrDefault(x => x.Code == code);
                    var cell = Db.cells.FirstOrDefault(x => x.LayerId == layer?.Id && x.Param1Value == param1Value
                        && x.Param2Value == param2Value);
                    return cell?.Cost ?? 0;

                case "[RM:St27]":
                case "[RM:Wire]":
                case "[RM:St16]":
                case "[RM:DD_FRAME]":
                case "[RM:SD_FRAME]":
                    var rawMaterial = Db.rawMaterials.FirstOrDefault(x => x.Code == code);
                    return rawMaterial?.Cost ?? 0;
                default:
                    return 0;
            }
        }

        public decimal ReplaceVariablesWithValues(string formulam, int param1value, int param2value)
        {
            throw new NotImplementedException();
        }

        public string ReplaceCodesWithIds(string formula)
        {
            throw new NotImplementedException();
        }

        public string ReplaceIdsWithCodes(string formula)
        {
            throw new NotImplementedException();
        }
    }
}