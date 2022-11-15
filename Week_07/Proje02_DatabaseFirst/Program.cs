using Proje02_DatabaseFirst;
using Proje02_DatabaseFirst.efcore;

var mt=new MultiTable();
// mt.MusteriSayisi();
mt.MusteriSatisListesi();
// mt.SatisYapilanMusteriler();







// NorthwindContext context = new NorthwindContext();

//Customer listesi alıyor
// List<Customer> customers = context.Customers.ToList();

// foreach (var customer in customers)
// {
//     Console.WriteLine(customer.CompanyName + "-" + customer.ContactName);
// }

//London'da yaşayan Customerların listesi

// List<Customer> customers = context.Customers.Where(c=>c.City=="London").ToList();
// foreach (var customer in customers)
// {
//     Console.WriteLine($"Company Name: {customer.CompanyName} - City: {customer.City} - Phone: {customer.Phone}");
// }
// Console.WriteLine("Bitti...");

//London'da yaşayan Customerların sadece CompanyName ve ContactName'lerini getirelim
// var customers = context
//     .Customers
//     .Select(c=>new {c.CompanyName, c.ContactName, c.City})
//     .Where(c=>c.City=="London")
//     .ToList();

// foreach (var customer in customers)
// {
//     Console.WriteLine($"Company Name: {customer.CompanyName} - City: {customer.City} - Contact Name: {customer.ContactName}");
// }
// Console.WriteLine("Bitti...");

//London'da yaşayan Customerların sadece CompanyName ve ContactName'lerini getirelim
//Nesne kullanarak


// List<CustomerModel> customers = context
//     .Customers
//     .Select(c=>new CustomerModel() {
//         CompanyName=c.CompanyName,
//         ContactName=c.ContactName,
//         City=c.City
//         })
//     .Where(c=>c.City=="London")
//     .ToList();

// foreach (var customer in customers)
// {
//     Console.WriteLine($"Company Name: {customer.CompanyName} - City: {customer.City} - Contact Name: {customer.ContactName}");
// }
// Console.WriteLine("Bitti...");

//Beverages kategorisindeki ürünlerin listsi
// var bevaragesProducts = context
//     .Products
//     .Where(p=>p.Category.CategoryName=="Beverages")
//     .ToList();

// foreach (var p in bevaragesProducts)
// {
//     Console.WriteLine(p.ProductName);
// }

//Suppliers tablosundaki Germany'de yaşayanları listeleyin
// var suppliersInGermany = context
//     .Suppliers
//     .Where(s=>s.Country=="Germany")
//     .ToList();
// foreach (var s in suppliersInGermany)
// {
//     Console.WriteLine(s.CompanyName);
// }
//Nancy adlı çalışının yaptığı satışlar
// var ordersOfNancy = context
//     .Orders
//     .Where(o=>o.Employee.FirstName=="Nancy" && o.ShipCountry=="Brazil")
//     .ToList();

// foreach (var o in ordersOfNancy)
// {
//     Console.WriteLine(o.OrderId);
// }
// Console.WriteLine($"Toplam satış sayısı: {ordersOfNancy.Count()}");

//Productları ID'lerine göre byükten küçüğe listeleyelim
// var products=context
// .Products
// .OrderByDescending(p=>p.ProductId)
// .ToList();
// foreach (var p in products)
// {
//     System.Console.WriteLine($"{p.ProductId}/{p.ProductName}");
// }

//En son satılan 5 ürünü listeleyelim
// var products=context
// .Products
// .OrderByDescending(p=>p.ProductId)
// .Take(5)
// .ToList();
// foreach (var p in products)
// {
//     System.Console.WriteLine($"{p.ProductId}/{p.ProductName}");
// }

//Fiyatı 10 ile 20 arasında olan ürünlerin adını ve fiyatını getirip listeleyelim, fiyata göre küçükten büyüğe sıralaylım.
//  var products=context
// .Products
// .Where(p=>p.UnitPrice>=10 && p.UnitPrice<=20)
// .Select(p=> new {
//     p.ProductName,
//     p.UnitPrice
// })
// .OrderBy(p=>p.UnitPrice) //to listen önce heryerde uygulanabilir ama burda kullanmak mantıklı daha az satırla uğraşır 
// .ToList();
// foreach (var p in products)
// {
//     Console.WriteLine($"{p.ProductName} -->{p.UnitPrice}");
// }

//Beverages kategorisindeki ürünlerin ortalama fiyatını ekrana yazdıralım.
// var ortalama=context
// .Products
// .Where(p=>p.Category.CategoryName=="Beverages")
// .Average(p=>p.UnitPrice);
// Console.WriteLine($"Beverages Fiyat Ortalaması:{ortalama}");

//Beverages kategorisindeki ürün adeti
// var adet=context
// .Products
// .Where(p=>p.Category.CategoryName=="Beverages")
// .Count();
// .Count(p=>p.Category.Categoryname=="Beverages");
// System.Console.WriteLine($"Beverages Ürün Adeti:{adet}");

//Beverages ve Condiments kategorilerinde toplam kaç adet ürün var
// var adet=context
// .Products
// .Count(p=>p.Category.CategoryName=="Beverages" || p.Category.CategoryName=="Condiments")
// System.Console.WriteLine($"Toplam ürün sayısı{adet}");

//Adın içinde tofu geçenler
// var products=context
// .Products
// .Where(p=>p.ProductName.Contains("tofu"))
// .ToList();
// foreach (var p in products)
// {
//     System.Console.WriteLine($"{p.ProductName}");
// }

// en ucuz ve en pahalı ürünü listeleyelim
// var minPrice=context.Products.Min(p=>p.UnitPrice);
// var maxPrice=context.Products.Max(p=>p.UnitPrice);

// var minProduct=context
// .Products
// .Where(p=>p.UnitPrice==minPrice)
// .Select(p=>new {
//     p.ProductName,
//     p.UnitPrice
// }).FirstOrDefault();
// var maxProduct=context
// .Products
// .Where(alex=>alex.UnitPrice==maxPrice)
// .Select(hooijdonk=>new {
//     hooijdonk.ProductName,
//     hooijdonk.UnitPrice
//     }).FirstOrDefault();
// Console.WriteLine($"MinPrice:{minPrice} --> Product: {minProduct.ProductName}-{minProduct.UnitPrice}");
// Console.WriteLine($"MaxPrice:{maxPrice} --> Product: {maxProduct.ProductName}-{maxProduct.UnitPrice}");
// var minPrice=context.Products.Min(p=>p.UnitPrice);
// var maxPrice=context.Products.Max(p=>p.UnitPrice);

// var minProducts=context
// .Products
// .Where(p=>p.UnitPrice==minPrice)
// .Select(p=>new {
//     p.ProductName
//     }).ToList();

// System.Console.WriteLine($"MinPrice Fiyatlı ürünlerin listesi");
// foreach (var m in minProducts)
// {
//     System.Console.WriteLine(p.ProductName);
// }
// var maxProducts=context
// .Products
// .Where(p=>p.UnitPrice==maxPrice)
// .Select(p=>new{
//     p.ProductName
//     }).ToList();
// System.Console.WriteLine($"MaxPrice Fiyatlı ürünlerin listesi");
// foreach (var m in maxProducts)
// {
//     System.Console.WriteLine(p.ProductName);
// }

// class CustomerModel
// {
//     public string? CompanyName { get; set; }
//     public string? ContactName { get; set; }
//     public string? City { get; set; }
// }