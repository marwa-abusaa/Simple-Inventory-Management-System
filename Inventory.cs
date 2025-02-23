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
            Product.log("Product is added successfully.");
        }

        public bool deleteProduct(string name)
        {
            foreach(var product in products)
            {
                if (product.Name == name)
                {
                    products.Remove(product);
                    Product.log("Product is deleted successfully.");
                    return true;
                }
            }
            return false;
        }
        public void displayAllProducts()
        {
            if (products.Count == 0)
            {
                Product.log("No products in the inventory.");
                return;
            }
            foreach (var product in products)
            {
                product.displayProductDetails(product);
            }
        }
    }
   
}
