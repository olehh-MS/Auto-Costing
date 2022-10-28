namespace Auto_Costing.Models
{
    public class LS_Cells
    {
        public Guid Id { get; set; }
        public int Param1Value { get; set; } // w
        public int Param2Value { get; set; } // h
        public decimal Cost { get; set; }
        public string Formula { get; set; } // null if layerId flat

        // References
        public Guid LayerId { get; set; }

    }
}
