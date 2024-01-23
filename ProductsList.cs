using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Francesco_Cheema___Inventory
{
    static class ProductsList
    {
        public static List<Products> MyList = new List<Products>();

        public static void addOne(Products per)
        {
            MyList.Add(per);
        }
    }
}
