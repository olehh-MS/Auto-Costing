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
                Code = "[L:N7]",
                Name = "N7",
                Description = "N7 layer",
                LS_LayerGroupId = null,
                LS_SubLayerId = null,
            },
            new LS_Layers()
            {
                Id = new Guid("93c5f0cf-cbb3-411b-a32b-e1f92c1ee479"),
                Code = "[L:N7.DirectMats]",
                Name = "MaterialN7",
                Description = "MaterialN7",
                LS_LayerGroupId = new Guid("390d8d84-8c3c-440a-9ae2-6441e2813701"),
                LS_SubLayerId = new Guid("0bc7716b-c2a5-4291-9ab2-2b50a042c3e4"),
            },
            new LS_Layers()
            {
                Id = new Guid("a00e44ac-58ab-4e8c-9f89-2799b1fbaa21"),
                Code = "[L:N7.Labor]",
                Name = "LaborN7",
                Description = "LaborN7",
                LS_LayerGroupId = new Guid("390d8d84-8c3c-440a-9ae2-6441e2813701"),
                LS_SubLayerId = null,
            },
            new LS_Layers()
            {
                Id = new Guid("0bc7716b-c2a5-4291-9ab2-2b50a042c3e4"),
                Code = "[L:Pack]",
                Name = "Packaging",
                Description = "Packaging layer",
                LS_LayerGroupId = null,
                LS_SubLayerId = null,
            },
        };

        public static List<LS_Cells> cells = new List<LS_Cells>
        {
            //packaging
            new LS_Cells()
            {
                Id = new Guid("8fb5be66-a15b-4acb-a0c1-14eb3427d56a"),
                Param1Value = 6, // w
                Param2Value = 4, // h
                Cost = 0.60m,
                Formula = "",
                LayerId = new Guid("0bc7716b-c2a5-4291-9ab2-2b50a042c3e4"), 
            },

            new LS_Cells()
            {
                Id = new Guid("0aded899-de6b-4418-ac11-53131b4beddf"),
                Param1Value = 8, // w
                Param2Value = 4, // h
                Cost = 0.60m,
                Formula = "",
                LayerId = new Guid("0bc7716b-c2a5-4291-9ab2-2b50a042c3e4"),
            },

            new LS_Cells()
            {
                Id = new Guid("5f644767-21a0-4a71-90eb-c72851c5eee2"),
                Param1Value = 10, // w
                Param2Value = 4, // h
                Cost = 0.60m,
                Formula = "",
                LayerId = new Guid("0bc7716b-c2a5-4291-9ab2-2b50a042c3e4"),
            },

//5
            new LS_Cells()
            {
                Id = new Guid("476aff74-12dc-485e-a428-988e5e6b103d"),
                Param1Value = 6, // w
                Param2Value = 5, // h
                Cost = 0.60m,
                Formula = "",
                LayerId = new Guid("0bc7716b-c2a5-4291-9ab2-2b50a042c3e4"),
            },

            new LS_Cells()
            {
                Id = new Guid("549d8b53-c387-4d82-a4e1-5acfca22b926"),
                Param1Value = 8, // w
                Param2Value = 5, // h
                Cost = 0.60m,
                Formula = "",
                LayerId = new Guid("0bc7716b-c2a5-4291-9ab2-2b50a042c3e4"),
            },

            new LS_Cells()
            {
                Id = new Guid("12b71a45-3066-41ab-adce-3f713c15ff4e"),
                Param1Value = 10, // w
                Param2Value = 5, // h
                Cost = 0.60m,
                Formula = "",
                LayerId = new Guid("0bc7716b-c2a5-4291-9ab2-2b50a042c3e4"),
            },

//6
            new LS_Cells()
            {
                Id = new Guid("0410e380-e827-4fb1-8636-ebfcd14e530f"),
                Param1Value = 6, // w
                Param2Value = 6, // h
                Cost = 0.60m,
                Formula = "",
                LayerId = new Guid("0bc7716b-c2a5-4291-9ab2-2b50a042c3e4"),
            },

            new LS_Cells()
            {
                Id = new Guid("9a2be3eb-97a2-44e8-82f1-0ca52ae1fb03"),
                Param1Value = 8, // w
                Param2Value = 6, // h
                Cost = 0.60m,
                Formula = "",
                LayerId = new Guid("0bc7716b-c2a5-4291-9ab2-2b50a042c3e4"),
            },

            new LS_Cells()
            {
                Id = new Guid("d7640ed7-1add-45e7-8dd3-b92b19bdb89a"),
                Param1Value = 10, // w
                Param2Value = 6, // h
                Cost = 0.60m,
                Formula = "",
                LayerId = new Guid("0bc7716b-c2a5-4291-9ab2-2b50a042c3e4"),
            },

//8
            new LS_Cells()
            {
                Id = new Guid("27bb3a46-58df-4af4-bb2a-fc86a15a55e5"),
                Param1Value = 8, // w
                Param2Value = 8, // h
                Cost = 0.70m,
                Formula = "",
                LayerId = new Guid("0bc7716b-c2a5-4291-9ab2-2b50a042c3e4"),
            },

            new LS_Cells()
            {
                Id = new Guid("5cb036bd-6722-4486-b5df-aa8bef8d84d2"),
                Param1Value = 10, // w
                Param2Value = 8, // h
                Cost = 0.70m,
                Formula = "",
                LayerId = new Guid("0bc7716b-c2a5-4291-9ab2-2b50a042c3e4"),
            },

//10
            new LS_Cells()
            {
                Id = new Guid("d415331c-228c-4871-a5ed-a03c8301326a"),
                Param1Value = 10, // w
                Param2Value = 10, // h
                Cost = 0.80m,
                Formula = "",
                LayerId = new Guid("0bc7716b-c2a5-4291-9ab2-2b50a042c3e4"),
            },


            //materialN7
            new LS_Cells()
            {
                Id = new Guid("9dcf3654-f0c1-444b-a30c-b8eb99d3eae2"),
                Param1Value = 6, // w
                Param2Value = 4, // h
                Cost = 0.74m,
                Formula = "(5 * [Param1Value] + 4 * [Param2Value] + 1.5 * [Param1Value] * [Param2Value]) / 144 * 1.125 * [RM:St27] + 0.6 * [L:Pack]",
                LayerId = new Guid("93c5f0cf-cbb3-411b-a32b-e1f92c1ee479"), 
            },

            new LS_Cells()
            {
                Id = new Guid("2c079dc5-770b-479f-aa9e-d37d449d5d8f"),
                Param1Value = 8, // w
                Param2Value = 4, // h
                Cost = 0.85m,
                Formula = "(5 * [Param1Value] + 4 * [Param2Value] + 1.5 * [Param1Value] * [Param2Value]) / 144 * 1.125 * [RM:St27] + 0.6 * [L:Pack]",
                LayerId = new Guid("93c5f0cf-cbb3-411b-a32b-e1f92c1ee479"),
            },

            new LS_Cells()
            {
                Id = new Guid("b7b1a206-fc86-45df-b33b-7129eb70bb3a"),
                Param1Value = 10, // w
                Param2Value = 4, // h
                Cost = 0.95m,
                Formula = "(5 * [Param1Value] + 4 * [Param2Value] + 1.5 * [Param1Value] * [Param2Value]) / 144 * 1.125 * [RM:St27] + 0.6 * [L:Pack]",
                LayerId = new Guid("93c5f0cf-cbb3-411b-a32b-e1f92c1ee479"),
            },

//5
            new LS_Cells()
            {
                Id = new Guid("3bd86653-5c2b-40b9-841d-624a69bde296"),
                Param1Value = 6, // w
                Param2Value = 5, // h
                Cost = 0.81m,
                Formula = "(5 * [Param1Value] + 4 * [Param2Value] + 1.5 * [Param1Value] * [Param2Value]) / 144 * 1.125 * [RM:St27] + 0.6 * [L:Pack]",
                LayerId = new Guid("93c5f0cf-cbb3-411b-a32b-e1f92c1ee479"),
            },

            new LS_Cells()
            {
                Id = new Guid("6564831f-b422-4e7d-a8cd-cd098a676477"),
                Param1Value = 8, // w
                Param2Value = 5, // h
                Cost = 0.92m,
                Formula = "(5 * [Param1Value] + 4 * [Param2Value] + 1.5 * [Param1Value] * [Param2Value]) / 144 * 1.125 * [RM:St27] + 0.6 * [L:Pack]",
                LayerId = new Guid("93c5f0cf-cbb3-411b-a32b-e1f92c1ee479"),
            },

            new LS_Cells()
            {
                Id = new Guid("80c647b0-da22-4e3a-aa52-ecc712b47482"),
                Param1Value = 10, // w
                Param2Value = 5, // h
                Cost = 1.04m,
                Formula = "(5 * [Param1Value] + 4 * [Param2Value] + 1.5 * [Param1Value] * [Param2Value]) / 144 * 1.125 * [RM:St27] + 0.6 * [L:Pack]",
                LayerId = new Guid("93c5f0cf-cbb3-411b-a32b-e1f92c1ee479"),
            },

//6
            new LS_Cells()
            {
                Id = new Guid("b899c29e-5217-4c13-a0e3-a06397bc42ac"),
                Param1Value = 6, // w
                Param2Value = 6, // h
                Cost = 0.87m,
                Formula = "(5 * [Param1Value] + 4 * [Param2Value] + 1.5 * [Param1Value] * [Param2Value]) / 144 * 1.125 * [RM:St27] + 0.6 * [L:Pack]",
                LayerId = new Guid("93c5f0cf-cbb3-411b-a32b-e1f92c1ee479"),
            },

            new LS_Cells()
            {
                Id = new Guid("68410ae7-06aa-47ab-bc5a-44d6b01cebb0"),
                Param1Value = 8, // w
                Param2Value = 6, // h
                Cost = 1.00m,
                Formula = "(5 * [Param1Value] + 4 * [Param2Value] + 1.5 * [Param1Value] * [Param2Value]) / 144 * 1.125 * [RM:St27] + 0.6 * [L:Pack]",
                LayerId = new Guid("93c5f0cf-cbb3-411b-a32b-e1f92c1ee479"),
            },

            new LS_Cells()
            {
                Id = new Guid("27d25dab-8842-46a4-956d-5a4a5e479696"),
                Param1Value = 10, // w
                Param2Value = 6, // h
                Cost = 1.13m,
                Formula = "(5 * [Param1Value] + 4 * [Param2Value] + 1.5 * [Param1Value] * [Param2Value]) / 144 * 1.125 * [RM:St27] + 0.6 * [L:Pack]",
                LayerId = new Guid("93c5f0cf-cbb3-411b-a32b-e1f92c1ee479"),
            },

//8
            new LS_Cells()
            {
                Id = new Guid("8155ccd8-7447-4726-a5d5-1135b462f4a0"),
                Param1Value = 8, // w
                Param2Value = 8, // h
                Cost = 1.21m,
                Formula = "(5 * [Param1Value] + 4 * [Param2Value] + 1.5 * [Param1Value] * [Param2Value]) / 144 * 1.125 * [RM:St27] + 0.6 * [L:Pack]",
                LayerId = new Guid("93c5f0cf-cbb3-411b-a32b-e1f92c1ee479"),
            },

            new LS_Cells()
            {
                Id = new Guid("01a33036-4149-47f7-a9c0-1ab6f2a95052"),
                Param1Value = 10, // w
                Param2Value = 8, // h
                Cost = 1.37m,
                Formula = "(5 * [Param1Value] + 4 * [Param2Value] + 1.5 * [Param1Value] * [Param2Value]) / 144 * 1.125 * [RM:St27] + 0.6 * [L:Pack]",
                LayerId = new Guid("93c5f0cf-cbb3-411b-a32b-e1f92c1ee479"),
            },

//10
            new LS_Cells()
            {
                Id = new Guid("6b5b8035-cb8e-4a87-9210-f8cf987d20f5"),
                Param1Value = 10, // w
                Param2Value = 10, // h
                Cost = 1.61m,
                Formula = "(5 * [Param1Value] + 4 * [Param2Value] + 1.5 * [Param1Value] * [Param2Value]) / 144 * 1.125 * [RM:St27] + 0.6 * [L:Pack]",
                LayerId = new Guid("93c5f0cf-cbb3-411b-a32b-e1f92c1ee479"),
            },


            // laborN7
            new LS_Cells()
            {
                Id = new Guid("727763c9-b3ff-469e-8ba5-3da2bbf29dab"),
                Param1Value = 6, // w
                Param2Value = 4, // h
                Cost = 1.2m,
                Formula = "",
                LayerId = new Guid("a00e44ac-58ab-4e8c-9f89-2799b1fbaa21"), //laborN7
            },

            new LS_Cells()
            {
                Id = new Guid("0593dc32-30c0-46bf-ade8-5027f5201815"),
                Param1Value = 8, // w
                Param2Value = 4, // h
                Cost = 1.2m,
                Formula = "",
                LayerId = new Guid("a00e44ac-58ab-4e8c-9f89-2799b1fbaa21"),
            },

            new LS_Cells()
            {
                Id = new Guid("93c946c5-a2d1-4e64-9e43-690c4aa30ba0"),
                Param1Value = 10, // w
                Param2Value = 4, // h
                Cost = 1.2m,
                Formula = "",
                LayerId = new Guid("a00e44ac-58ab-4e8c-9f89-2799b1fbaa21"),
            },

//5
            new LS_Cells()
            {
                Id = new Guid("7f5a2b1f-c3f8-41e5-8815-2b3df4155aaf"),
                Param1Value = 6, // w
                Param2Value = 5, // h
                Cost = 1.35m,
                Formula = "",
                LayerId = new Guid("a00e44ac-58ab-4e8c-9f89-2799b1fbaa21"),
            },

            new LS_Cells()
            {
                Id = new Guid("0fd5cf07-ad63-4dc2-abb1-270b47af3654"),
                Param1Value = 8, // w
                Param2Value = 5, // h
                Cost = 1.35m,
                Formula = "",
                LayerId = new Guid("a00e44ac-58ab-4e8c-9f89-2799b1fbaa21"),
            },

            new LS_Cells()
            {
                Id = new Guid("11797e3f-b421-4daa-ac28-fd5164594532"),
                Param1Value = 10, // w
                Param2Value = 5, // h
                Cost = 1.35m,
                Formula = "",
                LayerId = new Guid("a00e44ac-58ab-4e8c-9f89-2799b1fbaa21"),
            },

//6
            new LS_Cells()
            {
                Id = new Guid("96114d6f-2fca-499d-bd33-41de3707bf69"),
                Param1Value = 6, // w
                Param2Value = 6, // h
                Cost = 1.5m,
                Formula = "",
                LayerId = new Guid("a00e44ac-58ab-4e8c-9f89-2799b1fbaa21"),
            },

            new LS_Cells()
            {
                Id = new Guid("51c473be-e848-4270-b394-624df7ef4acd"),
                Param1Value = 8, // w
                Param2Value = 6, // h
                Cost = 1.5m,
                Formula = "",
                LayerId = new Guid("a00e44ac-58ab-4e8c-9f89-2799b1fbaa21"),
            },

            new LS_Cells()
            {
                Id = new Guid("77eb4638-d14d-4911-b9d9-e58241b68cbf"),
                Param1Value = 10, // w
                Param2Value = 6, // h
                Cost = 1.5m,
                Formula = "",
                LayerId = new Guid("a00e44ac-58ab-4e8c-9f89-2799b1fbaa21"),
            },

//8
            new LS_Cells()
            {
                Id = new Guid("061c715d-aca6-49fb-a1af-b86f494790cb"),
                Param1Value = 8, // w
                Param2Value = 8, // h
                Cost = 1.65m,
                Formula = "",
                LayerId = new Guid("a00e44ac-58ab-4e8c-9f89-2799b1fbaa21"),
            },

            new LS_Cells()
            {
                Id = new Guid("5cc78856-ae9a-4a09-b027-8d855ca91779"),
                Param1Value = 10, // w
                Param2Value = 8, // h
                Cost = 1.65m,
                Formula = "",
                LayerId = new Guid("a00e44ac-58ab-4e8c-9f89-2799b1fbaa21"),
            },

//10
            new LS_Cells()
            {
                Id = new Guid("8ee2c1dd-3644-4b9b-a362-97371dbf15ea"),
                Param1Value = 10, // w
                Param2Value = 10, // h
                Cost = 1.8m,
                Formula = "",
                LayerId = new Guid("a00e44ac-58ab-4e8c-9f89-2799b1fbaa21"),
            },


            //n7
            new LS_Cells()
            {
                Id = new Guid("0ec19b09-da5a-4cb5-a70a-ad39c8ebad0d"),
                Param1Value = 6, // w
                Param2Value = 4, // h
                Cost = 1.94m,
                Formula = "[L:N7.DirectMats] + [L:N7.Labor]",
                LayerId = new Guid("f34d73cf-d706-43e3-bf50-703ca242e2b4"), //N7
            },

            new LS_Cells()
            {
                Id = new Guid("41023b1f-e3c1-457e-bc35-e8de4aa93390"),
                Param1Value = 8, // w
                Param2Value = 4, // h
                Cost = 2.05m,
                Formula = "[L:N7.DirectMats] + [L:N7.Labor]",
                LayerId = new Guid("f34d73cf-d706-43e3-bf50-703ca242e2b4"),
            },

            new LS_Cells()
            {
                Id = new Guid("4853d5c0-dffd-4aa7-8477-60ed3a261cf9"),
                Param1Value = 10, // w
                Param2Value = 4, // h
                Cost = 2.15m,
                Formula = "[L:N7.DirectMats] + [L:N7.Labor]",
                LayerId = new Guid("f34d73cf-d706-43e3-bf50-703ca242e2b4"),
            },

//5
            new LS_Cells()
            {
                Id = new Guid("b5b88c73-9383-4a4c-8d8e-5877c204127a"),
                Param1Value = 6, // w
                Param2Value = 5, // h
                Cost = 2.16m,
                Formula = "[L:N7.DirectMats] + [L:N7.Labor]",
                LayerId = new Guid("f34d73cf-d706-43e3-bf50-703ca242e2b4"),
            },

            new LS_Cells()
            {
                Id = new Guid("7bd794c1-76f9-4fd1-986d-273363de9270"),
                Param1Value = 8, // w
                Param2Value = 5, // h
                Cost = 2.27m,
                Formula = "[L:N7.DirectMats] + [L:N7.Labor]",
                LayerId = new Guid("f34d73cf-d706-43e3-bf50-703ca242e2b4"),
            },

            new LS_Cells()
            {
                Id = new Guid("01e29ed4-973a-490b-8131-0197caec9761"),
                Param1Value = 10, // w
                Param2Value = 5, // h
                Cost = 2.39m,
                Formula = "[L:N7.DirectMats] + [L:N7.Labor]",
                LayerId = new Guid("f34d73cf-d706-43e3-bf50-703ca242e2b4"),
            },

//6
            new LS_Cells()
            {
                Id = new Guid("74e27b54-fe1b-4902-ac81-a39dd5b5518c"),
                Param1Value = 6, // w
                Param2Value = 6, // h
                Cost = 2.37m,
                Formula = "[L:N7.DirectMats] + [L:N7.Labor]",
                LayerId = new Guid("f34d73cf-d706-43e3-bf50-703ca242e2b4"),
            },

            new LS_Cells()
            {
                Id = new Guid("07f3fb49-f31b-4408-b70f-8f515cbe7801"),
                Param1Value = 8, // w
                Param2Value = 6, // h
                Cost = 2.50m,
                Formula = "[L:N7.DirectMats] + [L:N7.Labor]",
                LayerId = new Guid("f34d73cf-d706-43e3-bf50-703ca242e2b4"),
            },

            new LS_Cells()
            {
                Id = new Guid("676e45e8-fa59-46f7-bd82-8307db2ef14f"),
                Param1Value = 10, // w
                Param2Value = 6, // h
                Cost = 2.63m,
                Formula = "[L:N7.DirectMats] + [L:N7.Labor]",
                LayerId = new Guid("f34d73cf-d706-43e3-bf50-703ca242e2b4"),
            },

//8
            new LS_Cells()
            {
                Id = new Guid("cb5b2721-94db-4e6a-a78d-f0c6cd054e01"),
                Param1Value = 8, // w
                Param2Value = 8, // h
                Cost = 2.86m,
                Formula = "[L:N7.DirectMats] + [L:N7.Labor]",
                LayerId = new Guid("f34d73cf-d706-43e3-bf50-703ca242e2b4"),
            },

            new LS_Cells()
            {
                Id = new Guid("3759e41f-9c08-4e3f-a246-285c168c9c53"),
                Param1Value = 10, // w
                Param2Value = 8, // h
                Cost = 3.02m,
                Formula = "[L:N7.DirectMats] + [L:N7.Labor]",
                LayerId = new Guid("f34d73cf-d706-43e3-bf50-703ca242e2b4"),
            },

//10
            new LS_Cells()
            {
                Id = new Guid("7fdd649c-8c25-4868-a0e7-1ed7fb990e36"),
                Param1Value = 10, // w
                Param2Value = 10, // h
                Cost = 3.41m,
                Formula = "[L:N7.DirectMats] + [L:N7.Labor]",
                LayerId = new Guid("f34d73cf-d706-43e3-bf50-703ca242e2b4"),
            },
        };

        public static List<RawMaterials> rawMaterials = new List<RawMaterials>()
        {
            new RawMaterials()
            {
                Id = new Guid("298fd5d5-66ff-49e5-81b1-32b56ae3e9d5"),
                Code = "[RM:St27]",
                Name = "GALV.SHT. ST.0.027",
                Description = "",
                Cost = 0.6m,
            },
            new RawMaterials()
            {
                Id = new Guid("dd132f6c-795e-4ec5-990c-875b91e8bf1f"),
                Code = "[RM:Wire]",
                Name = "WIRE",
                Description = "",
                Cost = 0.63m,
            },
            new RawMaterials()
            {
                Id = new Guid("b6214462-0755-4488-9df4-4545e2c8d7d3"),
                Code = "[RM:St16]",
                Name = "GALV.SHT. ST.0.016",
                Description = "",
                Cost = 0.7m,
            },
            new RawMaterials()
            {
                Id = new Guid("4edf7d90-28a2-4784-9204-223164a623f2"),
                Code = "[RM:DD_FRAME]",
                Name = "DD FRAME EXTR.PPTD",
                Description = "",
                Cost = 0.68m,
            },
            new RawMaterials()
            {
                Id = new Guid("894cec20-edad-4418-9031-7cecc524ba71"),
                Code = "[RM:SD_FRAME]",
                Name = "SD FRAME EXTR.PPTD",
                Description = "",
                Cost = 0.57m,
            },
        };
    }
}
