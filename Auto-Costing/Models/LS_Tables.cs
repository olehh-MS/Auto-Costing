namespace Auto_Costing.Models
{
    public class LS_Tables
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        
        public Guid? RootID { get; set; }
    }
}
