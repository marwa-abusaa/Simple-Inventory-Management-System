using Simple_Inventory_Management_System.Domain;


namespace Simple_Inventory_Management_System.Services
{
    public class InventoryService
    {
        public Inventory InventoryProp;

        public InventoryService()
        {
            InventoryProp = new Inventory();
        }
        public void AddProduct(string name, double price, int quantity)
        {
            InventoryProp.Products.Add(new Product(name, price, quantity));
        }

        public bool DeleteProduct(string name)
        {
            if (InventoryProp.Products.Count == 0)
            {               
                return false;
            }
            Product? product = Search(name);
            if (product != null)
            {
                InventoryProp.Products.Remove(product);
                return true;
            }
            return false;
        }
        public void DisplayAllProducts()
        {
            if (InventoryProp.Products.Count == 0)
            {
                return;
            }          
            foreach (var product in InventoryProp.Products)
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
            foreach (var product in InventoryProp.Products)
            {
                if (string.Equals(product.Name, name, StringComparison.OrdinalIgnoreCase))
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
