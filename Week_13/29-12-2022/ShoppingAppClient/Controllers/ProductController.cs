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
    public class ProductController : Controller
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

        public async Task<IActionResult> Create()
        {
            var kategoriler = new List<CategoryViewModel>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5200/api/categories/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    kategoriler = JsonConvert.DeserializeObject<List<CategoryViewModel>>(apiResponse);
                }
            }
            ProductViewModel productViewModel = new ProductViewModel
            {
                Categories = kategoriler
            };
            return View(productViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Create(ProductViewModel productViewModel)
        {
            if(ModelState.IsValid)
            {
                //CreateAsync adýnda bir HttpResponse metodu kullanacaðýz.
            }
            return View();
        }
    }
}