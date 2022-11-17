using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using KitabeviApp.Models;
using Microsoft.EntityFrameworkCore;

namespace KitabeviApp.Controllers;

public class HomeController : Controller
{
    KitabeviContext context = new KitabeviContext();
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult KategoriListesi()
    {
        var kategoriler = context.Kategoriler.ToList();
        return View(kategoriler);
    }
    public IActionResult YazarListesi()
    {
        var yazarlar = context.Yazarlar.ToList();
        return View(yazarlar);
    }
    public IActionResult KitapListesi(int? id = null)
    {
        var kitaplar = context
            .Kitaplar
            .Where(k=>k.KategoriId==id)
            .Include(k => k.Kategori)
            .Include(k => k.Yazar)
            .ToList();
        return View(kitaplar);
    }
public IActionResult Detay(int id)
{
    var kitap= context
    .Kitaplar
    .Where(k=>k.Id==id)
    .FirstOrDefault();
    return View(kitap);
}

}
