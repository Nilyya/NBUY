using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShoppingAppClient.Models;
using System.Diagnostics;

namespace ShoppingAppClient.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var products = new List<ProductViewModel>();
            using (var httpClient = new HttpClient())
            {
                using (var reponse = await httpClient.GetAsync("http://localhost:5200/api/Products"))
                {
                    string apiResponse = await reponse.Content.ReadAsStringAsync();
                    products = JsonConvert.DeserializeObject<List<ProductViewModel>>(apiResponse);
                }
            }
            return View(products);
        }

        public async Task<IActionResult> Details(int id)
        {
            var product = new ProductViewModel();
            using (var httpClient = new HttpClient())
            {
                using (var reponse = await httpClient.GetAsync($"http://localhost:5200/api/Products/{id}"))
                {
                    string apiResponse = await reponse.Content.ReadAsStringAsync();
                    product = JsonConvert.DeserializeObject<ProductViewModel>(apiResponse);
                }
            }
            return View(product);
        }

        public async Task<IActionResult> GetProducts20000()
        {
            var products = new List<ProductViewModel>();
            using (var httpClient = new HttpClient())
            {
                using (var reponse = await httpClient.GetAsync("http://localhost:5200/api/Products"))
                {
                    string apiResponse = await reponse.Content.ReadAsStringAsync();
                    products = JsonConvert.DeserializeObject<List<ProductViewModel>>(apiResponse);
                }
            }
            products = products.Where(p => p.Price >= 20000).ToList();
            return View("Index", products);
        }
    }
}