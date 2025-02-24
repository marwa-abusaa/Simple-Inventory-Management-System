// See https://aka.ms/new-console-template for more information
//main 
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

        //add new product
        inventory.AddProduct(name, price, quantity);
    }
    static void ViewProducts(Inventory inventory)
    {
        //view products
        inventory.DisplayAllProducts();
    }
    static void DeleteProduct(Inventory inventory)
    {
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();

        //delete product
        inventory.DeleteProduct(name);
    }
    static void SearchProduct(Inventory inventory)
    {
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();

        //search product
        inventory.SearchProduct(name);
    }
    //static void EditProduct(Inventory inventory)
    //{
    //    Console.Write("Enter product name: ");
    //    string name = Console.ReadLine();

    //    Console.Write("What do you want to update? ");
    //    EditMenu();
    //    string choice = Console.ReadLine();
    //    string field="";
    //    switch (choice)
    //    {
    //        case "1":
    //            {
    //                field = "Name";
    //                Console.Write("Enter new name: ");
    //                break;
    //            }
                
    //        case "2":
    //            {
    //                field = "Price";
    //                Console.Write("Enter new price: ");
    //                break;
    //            }
    //        case "3":
    //            {
    //                field = "Quantity";
    //                Console.Write("Enter new quantity: ");
    //                break;
    //            }
    //    }

    //    string newValue = Console.ReadLine();
    //    //edit product
    //    inventory.EditProduct(name, field, newValue);

    //}

    static void EditProduct2(Inventory inventory)
    {
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();

        if (inventory.Search(name)==null)
        {
            return;
        }

        Console.Write("What do you want to update? ");
        EditMenu();
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                {
                    while (true)
                    {
                        Console.Write("Enter new name: ");
                        string newName = Console.ReadLine();
                        if (newName != string.Empty)
                        {
                            inventory.EditName(newName);
                            break;
                        }
                        Console.WriteLine("Please enter the name of product:");
                    }
                    break;
                }

            case "2":
                {
                    double newPrice;
                    while (true)
                    {
                        Console.Write("Enter new price: ");
                        if (double.TryParse(Console.ReadLine(), out newPrice) && newPrice >= 0)
                        {
                            inventory.EditPrice(name, newPrice);
                            break;
                        }
                        Console.WriteLine("Invalid input! Please enter a number:");
                    }
                    break;
                }
            case "3":
                {
                    int newQuantity;
                    while (true)
                    {
                        Console.Write("Enter new quantity: ");
                        if (int.TryParse(Console.ReadLine(), out newQuantity) && newQuantity >= 0)
                        {
                            inventory.EditQuantity(name, newQuantity);
                            break;
                        }
                        Console.WriteLine("Invalid input! Please enter a number:");
                    }
                    break;
                }
            default:
                {
                    Console.WriteLine("Please, choose a valid number!");
                    break;
                }               
               
        }

    }
    static void EditMenu()
    {
        Console.WriteLine("\n1. Product Name");
        Console.WriteLine("2. Product Price");
        Console.WriteLine("3. Product Quantity");
        Console.Write("Choose an option: ");
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
                    EditProduct2(inventory);
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