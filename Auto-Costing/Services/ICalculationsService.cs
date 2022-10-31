using Auto_Costing.Models;

namespace Auto_Costing.Services
{
    public interface ICalculationsService
    {
        decimal CalculateStringFormula(string formula);
        decimal ReplaceVariablesWithValues(string formulam, int param1value, int param2value);
        string ReplaceCodesWithIds(string formula);
        string ReplaceIdsWithCodes(string formula);
    }
}
