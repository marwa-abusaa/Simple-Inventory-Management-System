
namespace Simple_Inventory_Management_System.Infrastructure;

public class DataBaseConnection
{
    public static string ConnectionString = Environment.GetEnvironmentVariable("INVENTORY_DB_CONNECTION")!;
}
