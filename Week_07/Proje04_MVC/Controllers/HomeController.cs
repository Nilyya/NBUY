using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Proje04_MVC.Controllers;
class Product
{
    public int Id { get; set; }
    public string? name { get; set; }
    public decimal Price { get; set; }

}
class Category
{
    public int Id { get; set; }
    public string Name { get; set; }

}
public class HomeController : Controller
{
    public IActionResult Index()
    {
        string ad = "Aylin";
        ViewBag.KisiAd = ad;
        string dil = "Tr";
        string selamlama;
        if (dil == "Tr")
        {
            selamlama = "Hoşgeldiniz!";
        }
        else if (dil == "En")
        {
            selamlama = "Welcome";
        }
        else
        {
            selamlama = "";
        }
        ViewBag.Selam = selamlama;
        return View();
    }
    public IActionResult About()
    {
        ViewBag.Hata = false;
        ViewData["Not"] = 75;

        List<string> adlar = new List<string>() { "Sema", "Sefa", "Tuğçe", "Sümmeye" };
        ViewData["adlar"] = adlar;

        List<string> bolumler = new List<string>() { "İnsan Kaynakları", "Muhasebe", "Eğitim", "Satış" };
        ViewBag.Bolumler = bolumler;
        return View();
    }
    public IActionResult GetProducts()
    {
        List<Product> products = new List<Product>(){
    new Product(){Id=1, name="Iphone13",Price=24000},
    new Product(){Id=2, name="Iphone14",Price=25000},
    new Product(){Id=3, name="Iphone15",Price=34000},
    new Product(){Id=4, name="Iphone16",Price=124000},
    new Product(){Id=5, name="Iphone17",Price=84000}
};
        //ViewBag.Products=products;
        return View(products);
    }

    public IActionResult GetCategory()
    {
        List<Category> categories = new List<Category>(){
        new Category(){Id=1, Name="Telefon"},
        new Category(){Id=2, Name="Bilgisayar"},
        new Category(){Id=3, Name="Elektronik"}
    };
        return View(categories);
    }
}
