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

        public Parts(int partID, string Part, int inventory, int a)
        {
            PartID = partID;
            PartName = Part;
            Inventory = inventory;
            Price = a;
        }

    }
}
