using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Francesco_Cheema___Inventory
{
    class Parts
    {
        [DisplayName(Order = 1, Name = "Part ID")]
        public int PartID { get; set; }

        [DisplayName("Part Name")]
        public string PartName { get; set; }

        [DisplayName(Order = 3, Name = "Inventory")]
        public int Inventory { get; set; }

        [DisplayName("Price")]
        public int Price { get; set; }  

        public Parts(int ID, string Part, string inventory, int a)
        {
            PartID = PartID;
            PartName = PartName;
            Inventory = a;
            Price = a;
        }
        
    }
}
