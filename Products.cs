using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Francesco_Cheema___Inventory
{
    public class Products
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Products(int productId, string name, decimal price, int inStock, int min, int max)
        {
            ProductID = productId;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int partId)
        {
            foreach (Part p in AssociatedParts)
            {
                if (p.PartID == partId)
                {
                    AssociatedParts.Remove(p);
                    return true;
                }
            }
            return false;
        }

        public Part lookupAssociatedPart(int partId)
        {
            foreach (Part p in AssociatedParts)
            {
                if (p.PartID == partId) { return p; }
            }
            return null;
        }

    }
}
