using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Francesco_Cheema___Inventory
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ListClass.MyList.Add(new Parts(0, "Wheel", 4, 300, 10, 1, "3"));
            ListClass.MyList.Add(new Parts(1, "Muffler", 17, 100, 7, 8, "9"));
            ListClass.MyList.Add(new Parts(2, "Transmission", 5, 1300, 12, 10, "4"));
            ListClass.MyList.Add(new Parts(3, "Tire", 8, 500, 14, 13, "6"));

            ProductsList.MyList.Add(new Products(0, "Nissan Skyline GTT 1999" , 1, 45000));
            ProductsList.MyList.Add(new Products(1, "Honda Civic SI 2023", 2, 37000));
            ProductsList.MyList.Add(new Products(2, "Toyota GT86", 1, 40000));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
