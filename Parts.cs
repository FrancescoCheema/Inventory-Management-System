using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Francesco_Cheema___Inventory
{
    public class Parts : Part
    {

        public Parts(int partID, string name, int inventory, decimal price, int min, int max, string idOrCompany)
            : base(partID, name, inventory, price, min, max, idOrCompany)
        {
        }
    }
}
