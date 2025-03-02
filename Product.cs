using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Simple_Inventory_Management_System
{
    class Product
    {
        private string name;
        private double price;
        private int quantity;
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Product(string name, double price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }
        public static void Log(string message)
        {
            Console.WriteLine(message);
        }
        public void DisplayProductDetails(Product p)
        {
            string product = $"{p.name}\t{p.price}\t{p.quantity}\t";
            Log(product);
        }
    }
}
