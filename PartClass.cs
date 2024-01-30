using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Francesco_Cheema___Inventory
{
    public class PartClass
    {
        [DisplayName("Part ID")]
        public int PartID { get; set; }

        [DisplayName("Part Name")]
        public string PartName { get; set; }

        [DisplayName("Inventory")]
        public int Inventory { get; set; }

        [DisplayName("Price")]
        public decimal Price { get; set; }

        public PartClass(int PartID, string Part, int inventory, decimal a)
        {
            PartID = PartID;
            PartName = Part;
            Inventory = inventory;
            Price = a;
        }
    }
}
