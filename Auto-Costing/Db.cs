using Auto_Costing.Models;

namespace Auto_Costing
{
    public static class Db
    {
        public static decimal GALV_SHT_ST_0_027 = 0.6m;
        public static decimal WIRE = 0.63m;
        public static decimal GALV_SHT_ST_0_016 = 0.7m;
        public static decimal DD_FRAME_EXTR_PPTD = 0.68m;
        public static decimal SD_FRAME_EXTR_PPTD = 0.57m;

        public static int[] width = new int[] { 6, 8, 10/*, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 36 */};
        public static int[] height = new int[] { 4, 5, 6, 8, 10/*, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30 */};

        public static int[] FINS_QTY = new int[] { 5, 6, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35, 38, 41, 44 };


        public static List<LS_Tables> roots = new List<LS_Tables>
        {
            new LS_Tables()
            {
                Id = new Guid("5abf72d1-fd97-4f41-bc90-149e5536b48f"),
                Name = "N7",
                Description = "STEEL OBD DAMPER",
            },
            new LS_Tables()
            {
                Id = new Guid("08b2434d-ed78-472e-abad-3778ac7d29c3"),
                Name = "GSA20",
                Description = "gsa20 des",
            },
            new LS_Tables()
            {
                Id = new Guid("18cd8a49-22b1-4482-9b05-b5f75b68c3e3"),
                Name = "GSA27",
                Description = "gsa27 desc",
            },
            new LS_Tables()
            {
                Id = new Guid("a4c709ae-2b8f-4bf7-a42c-93ed6904a5d5"),
                Name = "MaterialN7",
                Description = "",
            },
            new LS_Tables()
            {
                Id = new Guid("c0a4f072-1c5b-4a74-b302-18e48cb93419"),
                Name = "LaborN7",
                Description = "",
            },
            new LS_Tables()
            {
                Id = new Guid("390d8d84-8c3c-440a-9ae2-6441e2813701"),
                Name = "Packaging",
                Description = "",
            },
        };

        public static List<LS_SubLayers> layers = new List<LS_SubLayers>
        {
            new LS_SubLayers()
            {
                Id = new Guid("aefe44bc-faaf-4a42-ac7b-c58e60220d93"),
                LayerId = new Guid("5abf72d1-fd97-4f41-bc90-149e5536b48f"), // n7
                SubLayerId = new Guid("a4c709ae-2b8f-4bf7-a42c-93ed6904a5d5"), // materials n7
            },
            new LS_SubLayers()
            {
                Id = new Guid("d3b40318-a22c-45cd-a0b1-5bc93fcdcceb"),
                LayerId = new Guid("5abf72d1-fd97-4f41-bc90-149e5536b48f"), // n7
                SubLayerId = new Guid("c0a4f072-1c5b-4a74-b302-18e48cb93419"), // labor n7
            },
            new LS_SubLayers()
            {
                Id = new Guid("554bbffc-a2ac-4901-b528-1c8cae3acb17"),
                LayerId = new Guid("a4c709ae-2b8f-4bf7-a42c-93ed6904a5d5"), // materials n7
                SubLayerId = new Guid("390d8d84-8c3c-440a-9ae2-6441e2813701"), // packagin
            },
        };

        public static List<LS_Cells> packaging = new List<LS_Cells>
        {
            new LS_Cells()
            {
                Id = new Guid("8fb5be66-a15b-4acb-a0c1-14eb3427d56a"),
                Param1Value = 6, // w
                Param2Value = 4, // h
                Cost = 0.60m,
                TableId = new Guid("390d8d84-8c3c-440a-9ae2-6441e2813701"),
            },

            new LS_Cells()
            {
                Id = new Guid("0aded899-de6b-4418-ac11-53131b4beddf"),
                Param1Value = 8, // w
                Param2Value = 4, // h
                Cost = 0.60m,
                TableId = new Guid("390d8d84-8c3c-440a-9ae2-6441e2813701"),
            },

            new LS_Cells()
            {
                Id = new Guid("5f644767-21a0-4a71-90eb-c72851c5eee2"),
                Param1Value = 10, // w
                Param2Value = 4, // h
                Cost = 0.60m,
                TableId = new Guid("390d8d84-8c3c-440a-9ae2-6441e2813701"),
            },


//5
            new LS_Cells()
            {
                Id = new Guid("476aff74-12dc-485e-a428-988e5e6b103d"),
                Param1Value = 6, // w
                Param2Value = 5, // h
                Cost = 0.60m,
                TableId = new Guid("390d8d84-8c3c-440a-9ae2-6441e2813701"),
            },

            new LS_Cells()
            {
                Id = new Guid("549d8b53-c387-4d82-a4e1-5acfca22b926"),
                Param1Value = 8, // w
                Param2Value = 5, // h
                Cost = 0.60m,
                TableId = new Guid("390d8d84-8c3c-440a-9ae2-6441e2813701"),
            },

            new LS_Cells()
            {
                Id = new Guid("12b71a45-3066-41ab-adce-3f713c15ff4e"),
                Param1Value = 10, // w
                Param2Value = 5, // h
                Cost = 0.60m,
                TableId = new Guid("390d8d84-8c3c-440a-9ae2-6441e2813701"),
            },


//6
            new LS_Cells()
            {
                Id = new Guid("0410e380-e827-4fb1-8636-ebfcd14e530f"),
                Param1Value = 6, // w
                Param2Value = 6, // h
                Cost = 0.60m,
                TableId = new Guid("390d8d84-8c3c-440a-9ae2-6441e2813701"),
            },

            new LS_Cells()
            {
                Id = new Guid("9a2be3eb-97a2-44e8-82f1-0ca52ae1fb03"),
                Param1Value = 8, // w
                Param2Value = 6, // h
                Cost = 0.60m,
                TableId = new Guid("390d8d84-8c3c-440a-9ae2-6441e2813701"),
            },

            new LS_Cells()
            {
                Id = new Guid("d7640ed7-1add-45e7-8dd3-b92b19bdb89a"),
                Param1Value = 10, // w
                Param2Value = 6, // h
                Cost = 0.60m,
                TableId = new Guid("390d8d84-8c3c-440a-9ae2-6441e2813701"),
            },


//8
            new LS_Cells()
            {
                Id = new Guid("27bb3a46-58df-4af4-bb2a-fc86a15a55e5"),
                Param1Value = 8, // w
                Param2Value = 8, // h
                Cost = 0.70m,
                TableId = new Guid("390d8d84-8c3c-440a-9ae2-6441e2813701"),
            },

            new LS_Cells()
            {
                Id = new Guid("5cb036bd-6722-4486-b5df-aa8bef8d84d2"),
                Param1Value = 10, // w
                Param2Value = 8, // h
                Cost = 0.70m,
                TableId = new Guid("390d8d84-8c3c-440a-9ae2-6441e2813701"),
            },

//10
            new LS_Cells()
            {
                Id = new Guid("d415331c-228c-4871-a5ed-a03c8301326a"),
                Param1Value = 10, // w
                Param2Value = 10, // h
                Cost = 0.80m,
                TableId = new Guid("390d8d84-8c3c-440a-9ae2-6441e2813701"),
            },
        };

        public static List<LS_Cells> laborN7 = new List<LS_Cells>
        {
            new LS_Cells()
            {
                Id = new Guid("727763c9-b3ff-469e-8ba5-3da2bbf29dab"),
                Param1Value = 6, // w
                Param2Value = 4, // h
                Cost = 1.2m,
                TableId = new Guid("c0a4f072-1c5b-4a74-b302-18e48cb93419"),
            },

            new LS_Cells()
            {
                Id = new Guid("0593dc32-30c0-46bf-ade8-5027f5201815"),
                Param1Value = 8, // w
                Param2Value = 4, // h
                Cost = 1.2m,
                TableId = new Guid("c0a4f072-1c5b-4a74-b302-18e48cb93419"),
            },

            new LS_Cells()
            {
                Id = new Guid("93c946c5-a2d1-4e64-9e43-690c4aa30ba0"),
                Param1Value = 10, // w
                Param2Value = 4, // h
                Cost = 1.2m,
                TableId = new Guid("c0a4f072-1c5b-4a74-b302-18e48cb93419"),
            },


//5
            new LS_Cells()
            {
                Id = new Guid("7f5a2b1f-c3f8-41e5-8815-2b3df4155aaf"),
                Param1Value = 6, // w
                Param2Value = 5, // h
                Cost = 1.35m,
                TableId = new Guid("c0a4f072-1c5b-4a74-b302-18e48cb93419"),
            },

            new LS_Cells()
            {
                Id = new Guid("0fd5cf07-ad63-4dc2-abb1-270b47af3654"),
                Param1Value = 8, // w
                Param2Value = 5, // h
                Cost = 1.35m,
                TableId = new Guid("c0a4f072-1c5b-4a74-b302-18e48cb93419"),
            },

            new LS_Cells()
            {
                Id = new Guid("11797e3f-b421-4daa-ac28-fd5164594532"),
                Param1Value = 10, // w
                Param2Value = 5, // h
                Cost = 1.35m,
                TableId = new Guid("c0a4f072-1c5b-4a74-b302-18e48cb93419"),
            },


//6
            new LS_Cells()
            {
                Id = new Guid("96114d6f-2fca-499d-bd33-41de3707bf69"),
                Param1Value = 6, // w
                Param2Value = 6, // h
                Cost = 1.5m,
                TableId = new Guid("c0a4f072-1c5b-4a74-b302-18e48cb93419"),
            },

            new LS_Cells()
            {
                Id = new Guid("51c473be-e848-4270-b394-624df7ef4acd"),
                Param1Value = 8, // w
                Param2Value = 6, // h
                Cost = 1.5m,
                TableId = new Guid("c0a4f072-1c5b-4a74-b302-18e48cb93419"),
            },

            new LS_Cells()
            {
                Id = new Guid("77eb4638-d14d-4911-b9d9-e58241b68cbf"),
                Param1Value = 10, // w
                Param2Value = 6, // h
                Cost = 1.5m,
                TableId = new Guid("c0a4f072-1c5b-4a74-b302-18e48cb93419"),
            },


//8
            new LS_Cells()
            {
                Id = new Guid("061c715d-aca6-49fb-a1af-b86f494790cb"),
                Param1Value = 8, // w
                Param2Value = 8, // h
                Cost = 1.65m,
                TableId = new Guid("c0a4f072-1c5b-4a74-b302-18e48cb93419"),
            },

            new LS_Cells()
            {
                Id = new Guid("5cc78856-ae9a-4a09-b027-8d855ca91779"),
                Param1Value = 10, // w
                Param2Value = 8, // h
                Cost = 1.65m,
                TableId = new Guid("c0a4f072-1c5b-4a74-b302-18e48cb93419"),
            },


//10
            new LS_Cells()
            {
                Id = new Guid("8ee2c1dd-3644-4b9b-a362-97371dbf15ea"),
                Param1Value = 10, // w
                Param2Value = 10, // h
                Cost = 1.8m,
                TableId = new Guid("c0a4f072-1c5b-4a74-b302-18e48cb93419"),
            },
        };

        public static List<LS_Cells> laborGSA20 = new List<LS_Cells>
        {

        };
    }
}
