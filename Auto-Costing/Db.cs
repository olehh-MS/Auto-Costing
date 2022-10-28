using Auto_Costing.Models;

namespace Auto_Costing
{
    public static class Db
    {

        public static int[] width = new int[] { 6, 8, 10/*, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 36 */};
        public static int[] height = new int[] { 4, 5, 6, 8, 10/*, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30 */};

        public static int[] FINS_QTY = new int[] { 5, 6, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35, 38, 41, 44 };


        public static List<LS_Tables> tables = new List<LS_Tables>
        {
            new LS_Tables()
            {
                Id = new Guid("5abf72d1-fd97-4f41-bc90-149e5536b48f"),
                Name = "N7",
                Description = "STEEL OBD DAMPER",
                RootID = null,
            },
        };

        public static List<LS_LayerGroups> layerGroups = new List<LS_LayerGroups>
        {
            new LS_LayerGroups()
            {
                Id = new Guid("390d8d84-8c3c-440a-9ae2-6441e2813701"),
                Name = "GroupN7",
                Description = "",
                LS_TableId = new Guid("5abf72d1-fd97-4f41-bc90-149e5536b48f"),
            },
        };

        public static List<LS_Layers> layers = new List<LS_Layers>
        {
            new LS_Layers()
            {
                Id = new Guid("f34d73cf-d706-43e3-bf50-703ca242e2b4"),
                Code = "[]",
                Name = "N7",
                Description = "N7 layer",
                LS_LayerGroupId = null,
                LS_SubLayerId = null,
            },
            new LS_Layers()
            {
                Id = new Guid("93c5f0cf-cbb3-411b-a32b-e1f92c1ee479"),
                Code = "[]",
                Name = "MaterialN7",
                Description = "N7 layer",
                LS_LayerGroupId = new Guid("390d8d84-8c3c-440a-9ae2-6441e2813701"),
                LS_SubLayerId = new Guid("0bc7716b-c2a5-4291-9ab2-2b50a042c3e4"),
            },
            new LS_Layers()
            {
                Id = new Guid("a00e44ac-58ab-4e8c-9f89-2799b1fbaa21"),
                Code = "[]",
                Name = "LaborN7",
                Description = "N7 layer",
                LS_LayerGroupId = new Guid("390d8d84-8c3c-440a-9ae2-6441e2813701"),
                LS_SubLayerId = null,
            },
            new LS_Layers()
            {
                Id = new Guid("0bc7716b-c2a5-4291-9ab2-2b50a042c3e4"),
                Code = "[]",
                Name = "Packaging",
                Description = "N7 layer",
                LS_LayerGroupId = null,
                LS_SubLayerId = null,
            },
        };

        public static List<LS_Cells> cells = new List<LS_Cells>
        {
            new LS_Cells()
            {
                Id = new Guid("8fb5be66-a15b-4acb-a0c1-14eb3427d56a"),
                Param1Value = 6, // w
                Param2Value = 4, // h
                Cost = 0.60m,
                Formula = "",
                LayerId = new Guid("390d8d84-8c3c-440a-9ae2-6441e2813701"),
            },
            
        };

        public static List<RawMaterials> rawMaterials = new List<RawMaterials>()
        {
            new RawMaterials()
            {
                Id = new Guid("298fd5d5-66ff-49e5-81b1-32b56ae3e9d5"),
                Code = "[]",
                Name = "GALV.SHT. ST.0.027",
                Description = "",
                Cost = 0.6m,
            },
            new RawMaterials()
            {
                Id = new Guid("dd132f6c-795e-4ec5-990c-875b91e8bf1f"),
                Code = "[]",
                Name = "WIRE",
                Description = "",
                Cost = 0.63m,
            },
            new RawMaterials()
            {
                Id = new Guid("b6214462-0755-4488-9df4-4545e2c8d7d3"),
                Code = "[]",
                Name = "GALV.SHT. ST.0.016",
                Description = "",
                Cost = 0.7m,
            },
            new RawMaterials()
            {
                Id = new Guid("4edf7d90-28a2-4784-9204-223164a623f2"),
                Code = "[]",
                Name = "DD FRAME EXTR.PPTD",
                Description = "",
                Cost = 0.68m,
            },
            new RawMaterials()
            {
                Id = new Guid("894cec20-edad-4418-9031-7cecc524ba71"),
                Code = "[]",
                Name = "SD FRAME EXTR.PPTD",
                Description = "",
                Cost = 0.57m,
            },
        };
    }
}
