using Auto_Costing.Models;

namespace Auto_Costing.Services
{
    public interface ILayersService
    {
        object BuildTable(Guid layerId);
        object GetLayers(Guid layerId);
        List<LS_Tables> GetTablesList();
    }
}
