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

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public Product(string name, double price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }
        public static void log(string message)
        {
            Console.WriteLine(message);
        }
        public void displayProductDetails(Product p)
        {
            string product = $"{p.name}\t {p.price}\t {p.quantity}\t";
            log(product);
        }
    }
}
