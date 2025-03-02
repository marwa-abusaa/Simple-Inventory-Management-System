// See https://aka.ms/new-console-template for more information

using Simple_Inventory_Management_System;

class Program
{
    static void AddNewProduct(Inventory inventory)
    {
        string name ="";
        
        while (true)
        {
            Console.Write("Enter product name: ");
            name = Console.ReadLine();
            if (name!=string.Empty)
                break;
            Console.WriteLine("Please enter the name of product.");
        }

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

        
        inventory.AddProduct(name, price, quantity);
    }
    static void ViewProducts(Inventory inventory)
    {
        
        inventory.DisplayAllProducts();
    }
    static void DeleteProduct(Inventory inventory)
    {
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();

        
        inventory.DeleteProduct(name);
    }
    static void SearchProduct(Inventory inventory)
    {
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();

        
        inventory.SearchProduct(name);
    }


    static void EditProduct(Inventory inventory)
    {
        Console.Write("Enter product name you want to update: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter new name, price, or quantity: ");

        if (inventory.Search(name)==null)
        {
            return;
        }
        string newName = "";

        while (true)
        {
            Console.Write("Enter product name: ");
            newName = Console.ReadLine();
            if (newName != string.Empty)
                break;
            Console.WriteLine("Please enter the name of product.");
        }

        double newPrice;
        while (true)
        {
            Console.Write("Enter product price: ");
            if (double.TryParse(Console.ReadLine(), out newPrice) && newPrice >= 0)
                break;
            Console.WriteLine("Invalid input! Please enter a number.");
        }

        int newQuantity;
        while (true)
        {
            Console.Write("Enter product quantity: ");
            if (int.TryParse(Console.ReadLine(), out newQuantity) && newQuantity >= 0)
                break;
            Console.WriteLine("Invalid input! Please enter a number.");
        }

        
        inventory.EditProduct(name, newPrice, newQuantity, newName);

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
                    EditProduct(inventory);
                    break;
                case "4":
                    DeleteProduct(inventory);
                    break;
                case "5":
                    SearchProduct(inventory);
                    break;
                case "6":
                    return;
                default:
                    {
                        Console.WriteLine("Please, choose a valid number!");
                        break;
                    }

            }
        }
    }
}