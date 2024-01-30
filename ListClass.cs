using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Francesco_Cheema___Inventory
{
    static class ListClass
    {
        public static List<Part> MyList = new List<Part>();

        public static void addOne(Part per)
        {
            MyList.Add(per);
        }
    }
}
