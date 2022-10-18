namespace Proje11_Collections_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
     
            //List<int> sayilar= new List<int>();
            //sayilar.Add(12);
            // sayilar.Add(120);
            // sayilar.Add(69);
            // sayilar.Add(28);
            // sayilar.Add(316);

            // List<string> isimler= new List<string>();
            // isimler.Add("Ali");
            // isimler.Add("YAsemin");
            // isimler.Add("Kemal");

            // foreach (var sayi in sayilar)
            // {
            //     Console.WriteLine(sayi);
            // }
            // foreach (var isim in isimler)
            // {
            //     Console.WriteLine(isim);
            // }
            // sayilar.Sort();
            // foreach (var sayi in sayilar)
            // {
            //     Console.WriteLine(sayi);
            // }

            //Product product1 = new Product() { Id=1, Name="Bilgisayar",Price=28000};
            //Product product2 = new Product() { Id = 2, Name = "Telefon", Price = 18000 };
            //Product product3 = new Product() { Id = 3, Name = "Masa Sandalye Takımı", Price = 8000 };

            ////List<Product> products = new List<Product>(){product1,product2,product3};
            //List<Product> products = new List<Product>();
            //products.Add(product1);
            //products.Add(product2);
            //products.Add(product3);
            List<Product> products = new List<Product>()
            {
            new Product(){Id=1, Name="Telefon", Price=19000},
            new Product(){Id=2, Name="Bilgisayar", Price=39000},
            new Product(){Id=3, Name="Masa Sandalye", Price=9000}

            };
            List<Product> newProduct = new List<Product>()
            {
              new Product(){Id=4,Name="Araba",Price=1600},
              new Product(){Id=5,Name="RAraba",Price=11600},
              new Product(){Id=6,Name="BAraba",Price=111600}



             };
                products.AddRange(newProduct);
            //products.ForEach(p=>{
            //    Console.WriteLine($"{p.Name}-{p.Price}");
            //    Console.WriteLine();
            //});

            int elemanSayısı=products.Count();

            products.Insert(0, new Product() { Id = 7, Name = "Gözlük", Price = 1254660 });

            products.InsertRange(3, newProduct);
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name}-{product.Price}");
            }
            Console.ReadLine();
        }
    }
}