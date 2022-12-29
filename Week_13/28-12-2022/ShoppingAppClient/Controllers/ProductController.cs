using Microsoft.AspNetCore.Mvc;

namespace ShoppingAppClient.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
