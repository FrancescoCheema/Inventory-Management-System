using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Francesco_Cheema___Inventory
{
    public static class ProductsList
    {
        public static List<Products> MyList = new List<Products>();

        public static void AddOne(Products product)
        {
            MyList.Add(product);
        }
    }
}
