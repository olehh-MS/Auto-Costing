namespace Auto_Costing.Models
{
    public class LS_Layers
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? LS_LayerGroupId { get; set; }
    }
}
