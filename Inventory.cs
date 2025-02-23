using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Inventory_Management_System
{
    class Inventory
    {
        private List<Product> products = [];
        public void addProduct(string name, double price, int quantity)
        {
            products.Add(new Product(name, price, quantity));
        }

    }
}
