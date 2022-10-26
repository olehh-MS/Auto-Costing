namespace Auto_Costing.Models
{
    public class LS_Cells
    {
        public Guid Id { get; set; }
        public int Param1Value { get; set; } // w
        public int Param2Value { get; set; } // h

        // ??
        // public decimal FlatCost { get; set; }
        // public decimal FormulaCost { get; set; }
        // public decimal TableCost { get; set; }

        public decimal Cost { get; set; }

        // References
        public Guid TableId { get; set; }

    }
}
