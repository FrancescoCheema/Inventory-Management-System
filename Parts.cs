using System.ComponentModel;
using System.Linq;

namespace Francesco_Cheema___Inventory
{
    class Parts
    {
        [DisplayName("Part ID")]
        public int PartID { get; set; }

        [DisplayName("Part Name")]
        public string PartName { get; set; }

        [DisplayName("Inventory")]
        public int Inventory { get; set; }

        [DisplayName("Price")]
        public int Price { get; set; }

        public int Max { get; set; }

        public int Value7 { get; set; }

        public string IdOrCompany { get; set; }

        public Parts(int partID, string Part, int inventory, int a, int max, int value7, string idorcompany)
        {
            PartID = partID;
            PartName = Part;
            Inventory = inventory;
            Price = a;
            Max = max;
            Value7 = value7;
            IdOrCompany = idorcompany;
        }

    }
}
