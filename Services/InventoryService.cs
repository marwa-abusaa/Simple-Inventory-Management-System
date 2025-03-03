using Simple_Inventory_Management_System.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Inventory_Management_System.Services
{
    class InventoryService
    {
        private Inventory _inventory;
        public Inventory InventoryProp => _inventory;

        public InventoryService()
        {
            _inventory = new Inventory();
        }
        public void AddProduct(string name, double price, int quantity)
        {
            _inventory.Products.Add(new Product(name, price, quantity));
        }

        public bool DeleteProduct(string name)
        {
            if (_inventory.Products.Count == 0)
            {               
                return false;
            }
            Product? product = Search(name);
            if (product != null)
            {
                _inventory.Products.Remove(product);
                return true;
            }
            return false;
        }
        public void DisplayAllProducts()
        {
            if (_inventory.Products.Count == 0)
            {
                return;
            }          
            foreach (var product in _inventory.Products)
            {
                ProductService.DisplayProductDetails(product);
            }
        }

        public void SearchProduct(string name)
        {
            Product? product = Search(name);
            if (product != null)
            {
                ProductService.DisplayProductDetails(product);
            }
        }

        public Product? Search(string name)
        {
            foreach (var product in _inventory.Products)
            {
                if (product.Name.ToLower() == name.ToLower())
                {
                    return product;
                }
            }
            return null;
        }


        public void EditProduct(string name, double newPrice, int newQuantity, string newName)
        {
            Product? product = Search(name);
            if (product != null)
            {
                product.Name = newName;
                product.Price = newPrice;
                product.Quantity = newQuantity;
            }
        }

    }
}
