using Simple_Inventory_Management_System.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Inventory_Management_System.Services
{
    class ProductService
    {
        public static void DisplayProductDetails(Product p)
        {
            Console.WriteLine($"{p.Name}\t{p.Price}\t{p.Quantity}\t");
        }
    }
}
