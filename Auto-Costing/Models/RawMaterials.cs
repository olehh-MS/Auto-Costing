namespace Auto_Costing.Models
{
    public class RawMaterials
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Units { get; set; }
        public decimal Cost { get; set; }
    }
}
