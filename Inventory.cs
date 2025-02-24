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
        public void AddProduct(string name, double price, int quantity)
        {
            products.Add(new Product(name, price, quantity));
            Product.Log("Product is added successfully.");
        }

        public void DeleteProduct(string name)
        {
            foreach(var product in products)
            {
                if (product.Name.ToLower() == name.ToLower())
                {
                    products.Remove(product);
                    Product.Log("Product is deleted successfully.");
                    return;
                }
            }
            Product.Log("Product not found");
        }
        public void DisplayAllProducts()
        {
            if (products.Count == 0)
            {
                Product.Log("No products in the inventory.");
                return;
            }
            foreach (var product in products)
            {
                product.DisplayProductDetails(product);
            }
        }

        public void SearchProduct(string name)
        {
            bool isfound = false;
            foreach (var product in products)
            {
                if (product.Name.ToLower() == name.ToLower())
                {
                    Product.Log("Product is found.\nName\tPrice\tQuantity");
                    product.DisplayProductDetails(product);
                    isfound = true;
                }
            }
            if (!isfound)
            {
                Product.Log("Product not found");
            }
        }
        public void EditProduct(string name, string field, string newValue)
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
                    Product.Log("Product is updates successfully.");
                }
            }
            Product.Log("Product not found");
        }
    }
   
}
