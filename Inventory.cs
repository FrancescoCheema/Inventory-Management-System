using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Francesco_Cheema___Inventory
{
    class Inventory
    {
        public static BindingList<Products> Products = new BindingList<Products>();
        public static BindingList<Part> Part = new BindingList<Part>();

        //Populate default data for testing
        public static void PopulateDummyData()
        {
            Part.Add(new Inhouse(GetNextId("part"), "TestPart1", Convert.ToDecimal(10.3), 3, 1, 5, 2140));
            Part.Add(new Inhouse(GetNextId("part"), "TestPart2", Convert.ToDecimal(8), 12, 3, 45, 5122));
            Part.Add(new Inhouse(GetNextId("part"), "TestPart3", Convert.ToDecimal(1.2), 5, 1, 12, 7435));
            Part.Add(new Outsourced(GetNextId("part"), "TestPart4", Convert.ToDecimal(3.54), 9, 2, 20, "Company A"));
            Part.Add(new Outsourced(GetNextId("part"), "TestPart5", Convert.ToDecimal(7.85), 24, 5, 100, "Company B"));
            Part.Add(new Outsourced(GetNextId("part"), "TestPart6", Convert.ToDecimal(.9), 1, 1, 99, "Company C"));

            Products.Add(new Products(GetNextId("product"), "TestProduct1", Convert.ToDecimal(45.1), 7, 1, 9));
            Products.Add(new Products(GetNextId("product"), "TestProduct2", Convert.ToDecimal(4), 3, 3, 14));
            Products.Add(new Products(GetNextId("product"), "TestProduct3", Convert.ToDecimal(20.12), 24, 15, 34));

            Products[0].addAssociatedPart(Part[0]);
            Products[0].addAssociatedPart(Part[3]);
            Products[1].addAssociatedPart(Part[1]);
            Products[1].addAssociatedPart(Part[4]);
            Products[2].addAssociatedPart(Part[2]);
            Products[2].addAssociatedPart(Part[5]);
        }

        //Verifies all fields are filled out and numeric fields contain numeric data
        public static string CheckFieldValidity(bool isPart, bool rbInHouse, bool rbOutsourced, string name, string inventory, string price, string min, string max, string machineId, string companyName)
        {
            string errorMessage = "";

            if (string.IsNullOrEmpty(name))
            {
                errorMessage += "'Name' field cannot be empty.";
            }
            if (string.IsNullOrEmpty(inventory) || !int.TryParse(inventory, out _))
            {
                if (!string.IsNullOrEmpty(errorMessage)) { errorMessage += "\n"; }
                errorMessage += "'Inventory' field cannot be empty and must be a whole number.";
            }
            if (string.IsNullOrEmpty(price) || !decimal.TryParse(price, out _))
            {
                if (!string.IsNullOrEmpty(errorMessage)) { errorMessage += "\n"; }
                errorMessage += "'Price' field cannot be empty and must be a number.";
            }
            if (string.IsNullOrEmpty(min) || !int.TryParse(min, out _))
            {
                if (!string.IsNullOrEmpty(errorMessage)) { errorMessage += "\n"; }
                errorMessage += "'Min' field cannot be empty and must be a whole number.";
            }
            if (string.IsNullOrEmpty(max) || !int.TryParse(max, out _))
            {
                if (!string.IsNullOrEmpty(errorMessage)) { errorMessage += "\n"; }
                errorMessage += "'Max' field cannot be empty and must be a whole number.";
            }
            if (isPart)
            {
                if (!rbInHouse && !rbOutsourced)
                {
                    if (!string.IsNullOrEmpty(errorMessage)) { errorMessage += "\n"; }
                    errorMessage += "Part type ('In-House' or 'Outsourced') must be selected.";
                }
                if (rbInHouse && (string.IsNullOrEmpty(machineId) || !int.TryParse(machineId, out int _)))
                {
                    if (!string.IsNullOrEmpty(errorMessage)) { errorMessage += "\n"; }
                    errorMessage += "'Machine ID' field cannot be empty and must be a whole number.";
                }
                if (rbOutsourced && string.IsNullOrEmpty(companyName))
                {
                    if (!string.IsNullOrEmpty(errorMessage)) { errorMessage += "\n"; }
                    errorMessage += "'Company Name' field cannot be empty.";
                }
            }

            return errorMessage;
        }

        public static int GetNextId(string type)
        {
            int nextId = 1;
            try
            {
                if (type == "part") { nextId = Part.Max(m => m.PartID) + 1; }
                if (type == "product") { nextId = Products.Max(m => m.ProductID) + 1; }
                return nextId;
            }
            catch
            {
                return nextId;
            }
        }

        public static void addProduct(Products newProduct)
        {
            Products.Add(newProduct);
        }

        public static bool removeProduct(int productId)
        {
            foreach (Products p in Products)
            {
                if (p.ProductID == productId)
                {
                    Products.Remove(lookupProduct(p.ProductID));
                    return true;
                }
            }
            return false;
        }

        public static Products lookupProduct(int productId)
        {
            foreach (Products p in Products)
            {
                if (p.ProductID == productId) { return p; }
            }
            return null;
        }

        public static void updateProduct(int productId, Products updatedProduct)
        {
            removeProduct(productId);
            addProduct(updatedProduct);
        }

        public static void addPart(Part newPart)
        {
            Part.Add(newPart);
        }

        public static bool deletePart(Part part)
        {
            foreach (Part p in Part)
            {
                if (p == part)
                {
                    Part.Remove(p);
                    return true;
                }
            }
            return false;
        }

        public static Part lookupPart(int partId)
        {
            foreach (Part p in Part)
            {
                if (p.PartID == partId) { return p; }
            }
            return null;
        }

        public static void updatePart(int partId, Part updatedPart)
        {
            deletePart(lookupPart(partId));
            addPart(updatedPart);
        }
    }
}