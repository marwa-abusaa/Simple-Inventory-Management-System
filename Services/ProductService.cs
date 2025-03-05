using Simple_Inventory_Management_System.Domain;


namespace Simple_Inventory_Management_System.Services
{
    class ProductService
    {
        public static void DisplayProductDetails(Product p)
        {
            Console.WriteLine($"{p.Name}\t{p.Price}\t{p.Quantity}\t");
        }
    }
}
