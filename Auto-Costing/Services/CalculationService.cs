using Auto_Costing.Models;
using System.Data;

namespace Auto_Costing.Services
{
    public class CalculationService : ICalculationsService
    {
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

            return (decimal)result;
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

        //public decimal PackagingCost(int w, int h)
        //{
        //    return Db.packaging.FirstOrDefault(x => x.Param1Value == w && x.Param2Value == h)?.Cost ?? 0;
        //}

        //public decimal FIN_LENGTH_FT(int w)
        //{
        //    return w/12;
        //}

        ///* change*/
        //public decimal FINS_QTY(int h)
        //{
        //    int hI = Array.IndexOf(Db.height, h);
        //    return Db.FINS_QTY[hI];
        //}

        //public decimal LaborCostN7(int w, int h)
        //{
        //    return Db.laborN7.FirstOrDefault(x => x.Param1Value == w && x.Param2Value == h)?.Cost ?? 0;
        //}

        //public decimal MaterialCostN7(int w, int h){

        //    var formula = (5 * w + 4 * h + 1.5m * w * h) / 144 * 1.125m * Db.GALV_SHT_ST_0_027 +
        //      0.6m * PackagingCost(w, h);

        //    return Math.Round(formula, 2);
        //}

        //public decimal getCostN7(int w, int h)
        //{
        //    var lab = LaborCostN7(w, h);
        //    var mat = MaterialCostN7(w, h);

        //    if (lab == 0 || mat == 0)
        //        return 0;

        //    return Math.Round(mat + lab, 2);
        //}

        //public decimal LaborCostGSA20(int w, int h)
        //{
        //    return Db.laborGSA20.FirstOrDefault(x => x.Param1Value == w && x.Param2Value == h)?.Cost ?? 0;
        //}

        //public decimal getCostPaintedSt(int w, int h)
        //{
        //    return FINS_QTY(h) * FIN_LENGTH_FT(w) * (0.085m * Db.GALV_SHT_ST_0_016 + 0.023m * Db.WIRE + 0.005m);
        //}

        //public decimal MaterialCostGSA20(int w, int h)
        //{
        //    decimal res = 0;
        //    if (w<20 && h<20)
        //    {
        //        res = getCostPaintedSt(w, h) * 2 + (w + h + 4) * 2 * Db.DD_FRAME_EXTR_PPTD / 12 + w * h * 0.004m;
        //    }
        //    else if (w<20 && h>=20)
        //    {
        //        res = getCostPaintedSt(w, h) * 2 + w  * 0.04m + (w + h + 4) * 2 * Db.DD_FRAME_EXTR_PPTD / 12 + w * h * 0.004m;
        //    }
        //    else if (w>=20 && h<20)
        //    {
        //        res = getCostPaintedSt(w, h) * 2 + h * 0.04m + (w + h + 4) * 2 * Db.DD_FRAME_EXTR_PPTD / 12 + w * h * 0.004m;
        //    }
        //    else
        //    {
        //        res = getCostPaintedSt(w, h) * 2 + (w + h)  * 0.04m + (w + h + 4) * 2 * Db.DD_FRAME_EXTR_PPTD / 12 + w * h * 0.004m;
        //    }
        //    return Math.Round(res, 2);
        //}

        //public decimal getCostGSA20(int w, int h)
        //{
        //    if (LaborCostGSA20(w, w) == 0 || MaterialCostGSA20(w, h) == 0 || PackagingCost(w, h) == 0)
        //        return 0;
        //    return Math.Round(LaborCostGSA20(w, h) + MaterialCostGSA20(w, h) + PackagingCost(w, h), 2);
        //}

        //public decimal getCostGSA27(int w, int h)
        //{
        //    if (getCostN7(w, h) == 0 || getCostGSA20(w, h) == 0)
        //        return 0;
        //    return Math.Round(getCostN7(w, h) + getCostGSA20(w, h),2);
        //}

        //public decimal[][] buildTable(string layer)
        //{
        //    layer = layer.ToUpper();

        //    decimal[][] data = new decimal[Db.height.Length][];

        //    for (int i = 0; i < Db.height.Length; i++)
        //    {
        //        data[i] = new decimal[Db.width.Length];
        //        for(int j = 0; j < Db.width.Length; j++)
        //        {
        //            decimal cost = 0;
        //            switch (layer)
        //            {
        //                case "MaterialN7":
        //                    cost = MaterialCostN7(Db.width[j], Db.height[i]);
        //                    break;
        //                case "MaterialGSA20":
        //                    cost = MaterialCostGSA20(Db.width[j], Db.height[i]);
        //                    break;
        //                case "Packaging":
        //                    cost = PackagingCost(Db.width[j], Db.height[i]);
        //                    break;
        //                case "LaborN7":
        //                    cost = LaborCostN7(Db.width[j], Db.height[i]);
        //                    break;
        //                case "LaborGSA20":
        //                    cost = LaborCostGSA20(Db.width[j], Db.height[i]);
        //                    break;
        //                case "GSA20":
        //                    cost = getCostGSA20(Db.width[j], Db.height[i]);
        //                    break;
        //                case "N7":
        //                    cost = getCostN7(Db.width[j], Db.height[i]);
        //                    break;
        //                default:
        //                    cost = 0;
        //                    break;
        //            }
        //            data[i][j] = cost;
        //        }
        //    }

        //    return data;
        //}

        //private decimal getCostByName(string name, int w, int h)
        //{
        //    switch (name)
        //    {
        //        case "MaterialN7":
        //            return MaterialCostN7(w, h);
        //        case "MaterialGSA20":
        //            return MaterialCostGSA20(w, h);
        //        case "Packaging":
        //            return PackagingCost(w, h);
        //        case "LaborN7":
        //            return LaborCostN7(w, h);
        //        case "LaborGSA20":
        //            return LaborCostGSA20(w, h);
        //        case "GSA20":
        //            return getCostGSA20(w, h);
        //        case "N7":
        //            return getCostN7(w, h);
        //        default:
        //            return 0;
        //    }
        //}

        //public object getLayers(Guid layerId, int w, int h)
        //{
        //    List<object> layers = new List<object>();

        //    var subLayers = Db.layers.Where(x => x.LayerId == layerId).ToList();

        //    foreach (var layer in subLayers)
        //    {
        //        var tableName = Db.roots.FirstOrDefault(x => x.Id == layer.SubLayerId)?.Name;

        //        if (tableName == null) continue;

        //        var tableValue = getCostByName(tableName, w, h);

        //        layers.Add(new
        //        {
        //            name = tableName,
        //            value = tableValue,
        //            subLayers = getLayers(layer.SubLayerId, w, h),
        //        });
        //    }

        //    return layers;
        //}


        //public List<LS_Tables> getTablesList()
        //{
        //    return Db.roots;
        //}

        //public object getWidthHeight()
        //{
        //    return new
        //    {
        //        width = Db.width,
        //        height = Db.height,
        //    };
        //}
    }
}