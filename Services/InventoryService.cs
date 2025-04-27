using Microsoft.Data.SqlClient;
using Simple_Inventory_Management_System.Domain;
using Simple_Inventory_Management_System.Infrastructure;


namespace Simple_Inventory_Management_System.Services;

public class InventoryService
{
    private string connectionString = DataBaseConnection.connectionString;

    
    public void AddProduct(string name, double price, int quantity)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string query = "INSERT INTO Products (Name, Price, Quantity) VALUES (@Name, @Price, @Quantity)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Quantity", quantity);

                command.ExecuteNonQuery();
            }
        }
    }

    public Product? Search(string name)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string query = "SELECT * FROM Products WHERE Name = @Name";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", name);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Product product = new Product
                        (
                            reader["Name"].ToString()!,
                            Convert.ToDouble(reader["Price"]),
                            Convert.ToInt32(reader["Quantity"])
                        );

                        return product;
                    }
                }
            }
        }
        return null;
    }

    public void SearchProduct(string name)
    {
        Product? product = Search(name);
        if (product != null)
        {
            ProductService.DisplayProductDetails(product);
        }
    }

}
