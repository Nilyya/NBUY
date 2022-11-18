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
    
    public IActionResult YasGrubu(){
        return View();
    }
    [HttpPost]
    public IActionResult YasGrubu(int yas, string ad){
        if(yas==0){
            ViewBag.YasGrubu="Lütfen bir yaş bilgisi giriniz!";
        }
        else if (yas<18)
        {
            ViewBag.YasGrubu=$"{ad}, reşit değilsin!";
        }else if (yas<40)
        {
            ViewBag.YasGrubu=$"{ad}, gençsin!";
        }else if (yas<60)
        {
            ViewBag.YasGrubu=$"{ad}, gençlere taş çıkartırsın!";
        }else {
            ViewBag.YasGrubu=$"{ad}, hala emekli olmadın mı?";
        }
        return View();
    }

    public IActionResult CreateProduct()
    {
        return View();
    }
    [HttpPost]
    public IActionResult CreateProduct(Product product)
    {
        //Burada veri tabanına kayıt işlemi vb. yapılacak.
        //Şimdilik biz gelen verilerin testini yapabilmek için tekrar sayfaya bastıralım.
        // ViewBag.ResultHeader = $"{productName} adlı ürün eklendi.";
        // ViewBag.ResultBody=$"Category: {productCategory}, Price: {productPrice}";
        return View(product);
    }
    


    // public IActionResult VerileriAl(string txtAd, int txtYas)
    // {
    //     return View();
    // }

}
