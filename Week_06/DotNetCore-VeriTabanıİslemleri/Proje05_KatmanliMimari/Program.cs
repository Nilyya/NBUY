using System.Data.SqlClient;
using Proje05_KatmanliMimari.BusinessLayer;
using Proje05_KatmanliMimari.DataAccessLayer;

using Proje05_KatmanliMimari.DataAccessLayer.Entities;

namespace Proje05_KatmanliMimari;
class Program
{
    static void Main(string[] args)
    {
        int secim;
        do
        {
            Console.Clear();
            Console.WriteLine("Choose DAtabase-->");
            Console.WriteLine("1-MsSql");
            Console.WriteLine("2-Sqlite");
            Console.WriteLine("0-Exit");
            Console.Write("Lütfen seçiminizi giriniz: ");
            secim = int.Parse(Console.ReadLine());
            if (secim == 1)
            {
                Menu(secim);
                Console.ReadLine();
            }
            else if (secim == 2)
            {
                Menu(secim);
                Console.ReadLine();
            }
            else if (secim != 0)
            {
                Console.WriteLine("Lütfen geçerli bir seçim yapınız!");
            }

        } while (secim != 0);
    }
    static void Menu(int dbType){
        Console.Clear();
        string dbName =dbType ==1 ? "MsSql" : "Sqlite";
        Console.WriteLine($"By {dbName}  Database - Nortwind");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("1-Product List");
        Console.WriteLine("2-Customer List");
        Console.WriteLine("Seçiminiz yapınız: ");
        int secim = int.Parse(Console.ReadLine());
        if (secim==1){
            if (dbType == 1)
            {
                ProductList(new SqlProductDAL());
            }
            else{
                ProductList(new SqliteProductDAL());
            }
            
        }
        else if (secim==2){
        
     
      if (dbType == 1)
            {
                ProductList(new SqlCustomerDAL());
            }
            else{
                ProductList(new SqliteCustomerDAL());
            }
        
    }
    static void ProductList(IProductDAL productDAL)
    {
        var productManager = new ProductManager(productDAL);
        List<Product> products = productManager.GetAllProducts();
        foreach (var product in products)
        {
            Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
        }
    }
    static void CustomerList(ICustomerDAL customerDAL)
    {
        var customerManager = new CustomerManager(customerDAL);
        List<Customer> customers = customerManager.GetAllCustomers();
        foreach (var customer in customers)
        {
            Console.WriteLine($"Id:{customer.CustomerID}, Name:{customer.CompanyName}, City:{customer.City}, Country:{customer.Country}");
        }
    }
  


}

   


    

