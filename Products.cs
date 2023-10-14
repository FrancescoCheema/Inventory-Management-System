using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Francesco_Cheema___Inventory
{
    class Products
    {
        [DisplayName("Product ID")]
        public int ProductID { get; set; }

        [DisplayName("Car Name")]
        public string ProductName { get; set; }

        [DisplayName("Inventory")]
        public int Inventory {  get; set; }

        [DisplayName("Price")]
        public int Price { get; set; }

        public int Max { get; set; }

        public int Min { get; set; }

        public Products(int productID, string name, int inventory, int price, int max, int min)
        {
            ProductID = productID;
            ProductName = name;
            Inventory = inventory;
            Price = price;
            Max = max;
            Min = min;
        }



    }
}
