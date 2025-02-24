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
            if (products.Count == 0)
            {
                Product.Log("No products in the inventory.");
                return;
            }
            Product product = Search(name);
            if (product != null)
            {
                products.Remove(product);
                Product.Log("Product is deleted successfully.");
                return;
            }
            
        }
        public void DisplayAllProducts()
        {
            if (products.Count == 0)
            {
                Product.Log("No products in the inventory.");
                return;
            }
            Product.Log("Name\tPrice\tQuantity");
            foreach (var product in products)
            {               
                product.DisplayProductDetails(product);
            }
        }

        public void SearchProduct(string name)
        {
            Product product = Search(name);
            if (product != null)
            {
                Product.Log("Product is found.\nName\tPrice\tQuantity");
                product.DisplayProductDetails(product);
            }          
        }

        public Product Search(string name)
        {
            foreach (var product in products)
            {
                if (product.Name.ToLower() == name.ToLower())
                {
                    return product;
                }
            }
            Product.Log("Product not found");
            return null;
        }
       

        public void EditProduct(string name, double newPrice, int newQuantity, string newName)
        {
            Product product = Search(name);
            if (product != null)
            {
                product.Name = newName;
                product.Price = newPrice;
                product.Quantity = newQuantity;
                Product.Log("Product is updates successfully.");
            }
        }
    }//class
}
