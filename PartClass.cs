using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Francesco_Cheema___Inventory
{
    class PartClass
    {
        [DisplayName("Part ID")]
        public int PartID { get; set; }

        [DisplayName("Part Name")]
        public string PartName { get; set; }

        [DisplayName("Inventory")]
        public int Inventory { get; set; }

        [DisplayName("Price")]
        public int Price { get; set; }

        public PartClass(int PartID, string Part, int inventory, int a)
        {
            PartID = PartID;
            PartName = Part;
            Inventory = inventory;
            Price = a;
        }
    }
}
