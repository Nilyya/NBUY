using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShoppingAppClient.Models;

namespace ShoppingAppClient.Controllers
{
    public class CategoryController : Controller
    {
        public async Task<IActionResult> IndexAsync()
        {
            //Api'miz kategori listesini getiren bir istekte bulunacak.
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5200/api/categories/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    kategoriler = JsonConvert.DeserializeObject<List<CategoryViewModel>>(apiResponse);
                }
            }
            return View(kategoriler);

        }
        
    }
}
