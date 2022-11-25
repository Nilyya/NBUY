using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< HEAD
using KitabeviApp.Data.EfCore;
=======
<<<<<<< HEAD
using KitabeviApp.Data.EfCore;
=======
using KitabeviApp.Web.Models;
>>>>>>> c0621aa9c5e8d09601c0ee027596a8c7fceb3252
>>>>>>> ecb69cfe09571123693c5d325c073fc4c2813469
using Microsoft.AspNetCore.Mvc;

namespace KitabeviApp.Web.ViewComponents
{
    public class KategorilerViewComponent : ViewComponent
    {
        KitabeviContext context = new KitabeviContext();
        public IViewComponentResult Invoke()
        {
            if (RouteData.Values["id"] != null)
            {
                ViewBag.SeciliKategori = int.Parse(RouteData.Values["id"].ToString());
            }

            return View(context.Kategoriler.ToList());
        }
    }
}