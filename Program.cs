// See https://aka.ms/new-console-template for more information
//main 
using Simple_Inventory_Management_System;

class Program
{
    static void AddNewProduct(Inventory inventory)
    {
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();

        double price;
        while (true)
        {
            Console.Write("Enter product price: ");
            if (double.TryParse(Console.ReadLine(), out price) && price >= 0)
                break;
            Console.WriteLine("Invalid input! Please enter a number.");
        }

        int quantity;
        while (true)
        {
            Console.Write("Enter product quantity: ");
            if (int.TryParse(Console.ReadLine(), out quantity) && quantity >= 0)
                break;
            Console.WriteLine("Invalid input! Please enter a number.");
        }

        //add new product
        inventory.AddProduct(name, price, quantity);
    }
    static void ViewProducts(Inventory inventory)
    {
        Console.WriteLine("Name\tPrice\tQuantity");
        inventory.DisplayAllProducts();
    }
    static void Menu()
    {
        Console.WriteLine("\n1. Add Product");
        Console.WriteLine("2. View Products");
        Console.WriteLine("3. Edit Product");
        Console.WriteLine("4. Delete Product");
        Console.WriteLine("5. Search Product");
        Console.WriteLine("6. Exit");
        Console.Write("\nChoose an option: ");
    }
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();
        Console.WriteLine("Welcome to our Inventory Management System!");

        while (true)
        {
            Menu();

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddNewProduct(inventory);
                        break;
                                      
                case "2":
                    ViewProducts(inventory);
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    return;
                default:
                    {
                        Console.WriteLine("Please, choose a correct number!");
                        choice = Console.ReadLine();
                        break;
                    }

            }
        }
    }
}