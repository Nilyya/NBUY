using System.Globalization;

namespace Proje01_Class_Field_Property_Uygulama
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Product class olacak içinde name, Price,Description
            //İstenildiği kadar Product bilgisinin girilmesini sağlayacağız
            //Kaç adet Product bilgisini kullanıcı belirlesin
            //Product ekleme işi bitince,eklenmiş Product'ları listelesin
            //Console.WriteLine("Kaç adet ürün gireceksiniz?:");
            //int adet=int.Parse(Console.ReadLine());
            //Product[] products = new Product[adet];
            //Product product;
            //for (int i = 0; i < adet; i++)
            //{
            //    product = new Product();

            //    Console.Write("Product Name:");
            //    product.Name = Console.ReadLine();

            //    Console.Write("Price:");
            //    product.Price=decimal.Parse(Console.ReadLine());

            //    Console.Write("description:");
            //    product.Description=Console.ReadLine();

            //    products[i] = product;
            //}
            //Console.WriteLine("Product Name\tProduct Price\tProduct Description");
            //foreach (var prd in products)
            //{
            //    Console.WriteLine($"{prd.Name}\t{prd.Price}\t{prd.Description}");
            //}



            #region RasgeleDegerUreterek
            Product[] products = new Product[5];
            Product product;
            string[] nameArray = { "GAlaxy A50", "HP Notebook", "MacBook Air M2", "IPhone 14Plus", "LG 27 İnç Monitör" };
            string[] descArray = { "İyidir", "Şasırtıcıdır", "Heyecan vericidir", "Soluğunuzu keser", "Tırtır" };
            decimal[]oldPrices=new decimal[5];
            Random random = new Random();
            Console.WriteLine("Yapılacak zam oranını giriniz:");
            decimal oran=decimal.Parse(Console.ReadLine());
    
            for (int i = 0; i < 5; i++)
            {
                product = new Product()
                {
                    Name = nameArray[random.Next(0, 5)],
                    Description = descArray[random.Next(0, 5)],
                    Price = random.Next(100, 1001)             

                };
                oldPrices[i]=product.Price;
                product.Price *= (1 + (oran / 100));
                products[i] = product;


                            }
            Console.WriteLine("Product Name".PadRight(30)+"OldPrice".PadRight(10)+"Price".PadRight(10)"Description");
            int j=0;
            foreach (var prd in products)
            {
                Console.WriteLine($"{prd.Name.PadRight(30)}{prd.Price.ToString().PadRight(10)}{oldPrice[j]}{prd.Description}");
                j++;
            }
            #endregion
        }
    }
}