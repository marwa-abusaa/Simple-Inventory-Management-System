using Simple_Inventory_Management_System.Domain;
using Simple_Inventory_Management_System.Infrastructure;


namespace Simple_Inventory_Management_System.Services;

public class InventoryService
{
    private readonly ProductRepository repository = new ProductRepository();


    public void AddProduct(string name, double price, int quantity)
    {
        repository.AddProduct(name, price, quantity);
    }

    public Product? Search(string name)
    {
        return repository.Search(name);
    }

    public void SearchProduct(string name)
    {
        repository.SearchProduct(name);
    }

    public List<Product> DisplayAllProducts()
    {
        return repository.DisplayAllProducts();
    }

    public bool DeleteProduct(string name)
    {
        return repository.DeleteProduct(name);
    }

    public void EditProduct(string name, double newPrice, int newQuantity, string newName)
    {
        repository.EditProduct(name, newPrice, newQuantity, newName);
    }

}
