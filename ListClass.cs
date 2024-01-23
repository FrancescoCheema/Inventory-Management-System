using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Francesco_Cheema___Inventory
{
    static class ListClass
    {
        public static List<Parts> MyList = new List<Parts>();

        public static void addOne(Parts per)
        {
            MyList.Add(per);
        }
    }
}
