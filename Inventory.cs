using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        public void deleteProduct(string name)
        {
            foreach(var product in products)
            {
                if (product.Name.ToLower() == name.ToLower())
                {
                    products.Remove(product);
                    Product.log("Product is deleted successfully.");
                    return;
                }
            }
            Product.log("Product not found");
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

        public void searchProduct(string name)
        {
            bool isfound = false;
            foreach (var product in products)
            {
                if (product.Name.ToLower() == name.ToLower())
                {
                    Product.log("Product is found.\nName\tPrice\tQuantity");
                    product.displayProductDetails(product);
                    isfound = true;
                }
            }
            if (!isfound)
            {
                Product.log("Product not found");
            }
        }
        public void editProduct(string name, string field, string newValue)
        {
            foreach (var product in products)
            {
                if (product.Name.ToLower() == name.ToLower())
                {
                    switch (field)
                    {
                        case "Name":
                            product.Name = newValue;
                            break;
                        case "Price":
                            product.Price = double.Parse(newValue);
                            break;
                        case "Quantity":
                            product.Quantity = int.Parse(newValue);
                            break;
                    }
                    Product.log("Product is updates successfully.");
                }
            }
            Product.log("Product not found");
        }
    }
   
}
