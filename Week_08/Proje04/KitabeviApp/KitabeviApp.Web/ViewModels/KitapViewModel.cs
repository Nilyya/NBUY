using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< HEAD
using KitabeviApp.Entity;
=======
using KitabeviApp.Web.Models;
>>>>>>> c0621aa9c5e8d09601c0ee027596a8c7fceb3252

namespace KitabeviApp.Web.ViewModels
{
    public class KitapViewModel
    {
        public Kitap Kitap { get; set; }
        public List<Yazar> Yazarlar { get; set; }
        public List<Kategori> Kategoriler { get; set; }
    }
}