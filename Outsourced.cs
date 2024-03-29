﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Francesco_Cheema___Inventory
{
    public class Outsourced : Part
    {
        public string CompanyName { get; set; }

        public Outsourced(int partId, string name, decimal price, int inStock, int min, int max, string companyName) : base(partId, name, price, inStock, min, max)
        {
            CompanyName = companyName;
        }
    }
}
