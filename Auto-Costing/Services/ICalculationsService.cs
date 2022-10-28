using Auto_Costing.Models;

namespace Auto_Costing.Services
{
    public interface ICalculationsService
    {
        decimal CalculateFormula(string formula, int w, int h);

        //decimal PackagingCost(int w, int h);
        //decimal FIN_LENGTH_FT(int w);
        //decimal FINS_QTY(int h);
        //decimal LaborCostN7(int w, int h);
        //decimal MaterialCostN7(int w, int h);
        //decimal getCostN7(int w, int h);
        //decimal LaborCostGSA20(int w, int h);
        //decimal getCostPaintedSt(int w, int h);
        //decimal MaterialCostGSA20(int w, int h);
        //decimal getCostGSA20(int w, int h);
        //decimal getCostGSA27(int w, int h);
        //decimal[][] buildTable(string layer);
        //object getLayers(Guid layerId, int w, int h);

        //List<LS_Tables> getTablesList();
        //object getWidthHeight();
    }
}
