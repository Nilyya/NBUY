using DiariesFood.Entity.Abstract;
using DiariesFood.Entity.Concrete.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiariesFood.Entity.Concrete
{
    public class Favorite : IEntityBase
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public List<FavoriteItem> FavoriteItems { get; set; }
    }
}