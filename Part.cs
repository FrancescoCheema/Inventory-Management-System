using System.ComponentModel;
using System.Linq;

namespace Francesco_Cheema___Inventory
{
    public abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public string IdOrCompany { get; set; }


        public Part(int partId, string name, decimal price, int inStock, int min, int max, string idorcompany)
        {
            PartID = partId;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            IdOrCompany = idorcompany;
        }

        protected Part(int partID, string name, int inventory, decimal price, int min, int max, string idOrCompany)
        {
            PartID = partID;
            Name = name;
            Price = price;
            Min = min;
            Max = max;
        }

        protected Part(int partId, string name, decimal price, int inStock, int min, int max)
        {
            PartID = partId;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }
    }
}
