using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Proje06_ModelBinding_Form.Models;

namespace Proje06_ModelBinding_Form.Controllers;

public class HomeController : Controller
{


    public IActionResult Index()
    {
        return View();
    }
    [HttpGet] //Gerek yok yazmayıncada aynı şeyi kabul ediyor
    public IActionResult YasGrubu()
    {
        return View();
    }
    [HttpPost]
    public IActionResult YasGrubu(int yas, string ad)
    {  
        if (yas == 0)
        {
            ViewBag.YasGrubu = $"Lütfen yaş bilgisi giriniz.";
        }
        else if (yas < 18)
        {
            ViewBag.YasGrubu = $"{ad},Reşit Değilsiniz";
        }
        else if (yas < 40)
        {
            ViewBag.YasGrubu = $"{ad},Gençsiniz";
        }
        else if (yas < 60)
        {
            ViewBag.YasGrubu = $"{ad},Gençlere taş çıkarırsınız";
        }
        else
        {
            ViewBag.YasGrubu = $"{ad},Emekli olmadınız mı";
        }
        return View();
    }
public IActionResult CreateProduct(Product product)
{
    return View(product);
}
public IActionResult CreateProduct()
{
    //Burada kayıt işlemi
    //Şimdilik veri testi için
    // ViewBag.ResultHeader=$"{productName} adlı ürün eklendi";
    // ViewBag.ResultBody=$"Category:{productCategory},Price:{productPrice}";
    return View();
}
    // public IActionResult VerileriAl(string txtAd, int txtYas)
    // {
    //     return View();
    // }

}
