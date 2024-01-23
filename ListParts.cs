using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Francesco_Cheema___Inventory
{
    static class ListParts
    {
        public static List<PartClass> MyList = new List<PartClass>();
        public static void addOne(PartClass per)
        {
            MyList.Add(per);
        }
    }
}
