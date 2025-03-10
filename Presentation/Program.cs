﻿using Simple_Inventory_Management_System.Services;

public class Program
{
    public static void AddNewProduct(InventoryService inventory)
    {
        var name = string.Empty;

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

        
        inventory.AddProduct(name!, price, quantity);
        Console.WriteLine("Product is added successfully.");
    }
    public static void ViewProducts(InventoryService inventory)
    {
        if (inventory.InventoryProp.Products.Any())
        {
            Console.WriteLine("Name\tPrice\tQuantity");
            inventory.DisplayAllProducts();
        }           
        else
            Console.WriteLine("No products in the inventory.");

    }
    public static void DeleteProduct(InventoryService inventory)
    {
        Console.Write("Enter product name: ");
        string? name = Console.ReadLine();

        if (inventory.DeleteProduct(name!) == false)
            Console.WriteLine("Product not found");
        else
            Console.WriteLine("Product deleted successfully.");
    }
    public static void SearchProduct(InventoryService inventory)
    {
        Console.Write("Enter product name: ");
        string? name = Console.ReadLine();

        if (inventory.Search(name!) == null)
        {
            Console.WriteLine("Product not found");
        }
        else
        {
            Console.WriteLine("Product is found.\nName\tPrice\tQuantity");
            inventory.SearchProduct(name!);
        }
            
    }


    public static void EditProduct(InventoryService inventory)
    {
        Console.Write("Enter product name you want to update: ");
        string? name = Console.ReadLine();       

        if (inventory.Search(name!)==null)
        {
            Console.WriteLine("Product not found.");
            return;
        }
        Console.WriteLine("Enter new name, price, or quantity: ");
        var newName = String.Empty;

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

        
        inventory.EditProduct(name!, newPrice, newQuantity, newName!);
        Console.WriteLine("Product updated successfully.");

    }

    public static void Menu()
    {
        Console.WriteLine("\n1. Add Product");
        Console.WriteLine("2. View Products");
        Console.WriteLine("3. Edit Product");
        Console.WriteLine("4. Delete Product");
        Console.WriteLine("5. Search Product");
        Console.WriteLine("6. Exit");
        Console.Write("\nChoose an option: ");
    }
    private static void Main(string[] args)
    {
        InventoryService _inventoryService = new InventoryService();

        Console.WriteLine("Welcome to our Inventory Management System!");

        while (true)
        {
            Menu();

            switch (Console.ReadLine())
            {
                case "1":
                    AddNewProduct(_inventoryService);
                        break;                                     
                case "2":
                    ViewProducts(_inventoryService);
                    break;
                case "3":
                    EditProduct(_inventoryService);
                    break;
                case "4":
                    DeleteProduct(_inventoryService);
                    break;
                case "5":
                    SearchProduct(_inventoryService);
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