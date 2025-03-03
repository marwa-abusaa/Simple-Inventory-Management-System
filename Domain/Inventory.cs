using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Simple_Inventory_Management_System.Domain
{
    class Inventory
    {
        private List<Product> _products;
        public Inventory()
        {
            _products = new List<Product>();
        }

        public List<Product> Products => _products;
        
    }
}
