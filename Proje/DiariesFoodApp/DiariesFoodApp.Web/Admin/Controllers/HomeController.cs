using Microsoft.AspNetCore.Mvc;
namespace DiariesFoodApp.Web.Admin.Controllers
{
    
        [Area("Admin")]
        public class HomeController : Controller
        {
            public IActionResult Index()
            {
                return View();
            }
        }
    
}
