using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ShoppingAppClient.Models;

namespace ShoppingAppClient.Controllers
{
    public class CategoryController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var categories = new List<CategoryViewModel>();
            using (var httpClient = new HttpClient())
            {
                using (var reponse = await httpClient.GetAsync("http://localhost:5200/api/Categories"))
                {
                    string apiResponse = await reponse.Content.ReadAsStringAsync();
                    categories = JsonConvert.DeserializeObject<List<CategoryViewModel>>(apiResponse);
                }
            }
            return View(categories);
        }

        public async Task<IActionResult> GetProductsByCategory(int id)
        {
            var urunler = new List<ProductViewModel>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"http://localhost:5200/api/Categories/{id}"))
                {
                    string stringResponse = await response.Content.ReadAsStringAsync();
                    urunler = JsonConvert.DeserializeObject<List<ProductViewModel>>(stringResponse);
                }
            }
            return RedirectToAction("Index", "Home", urunler);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}