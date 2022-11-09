using System.Data.SqlClient;

namespace Proje03_VerilerinNesneyleTasinmasi;
class Program
{
    static void Main(string[] args)
    {
        // List<Product> products=GetAllProducts();
        // foreach (var product in products)
        // {
        //     Console.WriteLine($"Id:{product.Id}, Name:{product.Name}, Price:{product.Price}, Stock:{product.Stock}");
        // }
        List<Customer> customers=GetAllcustomers();
        foreach (var customer in customers)
        {
            
        }
    }
    static List<Customer> GetCustomers()
    {
        List<Customer> customers= new List<Customer>();
        using(var connection=GetSqlConnection())
        {
            try
            {
            connection.Open();
            string queryString="SELECT";
              SqlCommand sqlCommand=new SqlCommand(queryString, connection);
                SqlDataReader sqlDataReader=sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    customers.Add(new Customer(){
                        Id= int.Parse(sqlDataReader[0].ToString()),
                        CompanyName=sqlDataReader[1].ToString(),
                        ContactName=sqlDataReader[2].ToString(),
                        Country=sqlDataReader[3].ToString()
                    });
                }
                sqlDataReader.Close();
            }  
      
        }
        return customers;
    }
    static List<Product> GetAllProducts()
    {
        List<Product> products= new List<Product>();
        using (var connection= GetSqlConnection())
        {
            try
            {
                connection.Open();
                string queryString="SELECT ProductId, ProductName, UnitPrice, UnitsInStock FROM Products";
                SqlCommand sqlCommand=new SqlCommand(queryString, connection);
                SqlDataReader sqlDataReader=sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    products.Add(new Product(){
                        Id=int.Parse(sqlDataReader[0].ToString()),
                        Name=sqlDataReader[1].ToString(),
                        Price=decimal.Parse(sqlDataReader[2].ToString()),
                        Stock=int.Parse(sqlDataReader[3].ToString())
                    });
                }
                sqlDataReader.Close();
            }
            catch (Exception)
            {
                
              Console.WriteLine("Bir sorun oluştu");
            }
            finally
            {
                connection.Close();
            }
        }
        return products;
    }
    static SqlConnection GetSqlConnection()
    {
     
        string connectionString = @"Server=DESKTOP-OFVK2FD;Database=Northwind; User Id=sa; Password=123";
       SqlConnection sqlConnection=new SqlConnection(connectionString);
       return sqlConnection;
    }
}