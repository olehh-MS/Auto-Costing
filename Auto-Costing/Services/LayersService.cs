using Auto_Costing.Models;

namespace Auto_Costing.Services
{
    public class LayersService : ILayersService
    {
        public object BuildTable(Guid layerId)
        {
            var list = Db.cells.Where(x => x.LayerId == layerId)
                .OrderBy(x => x.Param1Value).ThenBy(x => x.Param2Value).ToList();

            var width = list.DistinctBy(x => x.Param1Value).Select(x => x.Param1Value).ToList();
            var height = list.DistinctBy(x => x.Param2Value).Select(x => x.Param2Value).ToList();

            decimal[][] array = new decimal[height.Count()][];

            for (int h = 0; h < height.Count(); h++)
            {
                array[h] = new decimal[width.Count()];

                for (int w = 0; w < width.Count(); w++)
                {
                    array[h][w] = list.Where(x => x.Param1Value == width[w] && x.Param2Value == height[h])
                        .Select(x => x.Cost).FirstOrDefault();
                }
            }

            return new {array, width, height};
        }

        public object GetLayers(Guid layerId)
        {
            List<object> layers = new List<object>();

            var layerGroup = Db.layerGroups.FirstOrDefault(x => x.LS_TableId == layerId);

            //if(layerGroup != null)
            //{
            //    var subLayers = Db.layers.Where(x => x.LS_LayerGroupId == layerGroup.Id).ToList();

            //    foreach(var subLayer in subLayers)
            //    {
            //        layers.Add(new
            //        {
            //            name = subLayer.Name,
            //            subLayers = GetLayers(subLayer.Id),
            //        });
            //    }
            //}
            //else
            //{
            //    var layer = Db.layers.Where(x => x.Id == layerId).FirstOrDefault();

            //    if(layer?.LS_TableId != null)
            //    {
            //        var subLayer = Db.tables.FirstOrDefault(x => x.Id == layer?.LS_TableId);

            //        if(subLayer != null)
            //            layers.Add(new
            //            {
            //                name = subLayer.Name,
            //                subLayers = GetLayers((Guid)subLayer.Id),
            //            });
            //    }
            //    else if(layer?.LS_SubLayerId != null)
            //    {
            //        var subLayer = Db.layers.FirstOrDefault(x => x.Id == layer.LS_SubLayerId);
                    
            //        if(subLayer != null)
            //            layers.Add(new
            //            {
            //                name = subLayer.Name,
            //                subLayers = GetLayers(subLayer.Id),
            //            });
            //    }
            //}

            return layers;
        }

        public List<LS_Tables> GetTablesList()
        {
            return Db.tables.ToList();
        }
    }
}
