using DiariesFood.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiariesFood.Entity.Concrete
{
    public class FavoriteItem : IEntityBase
    {
        public int Id { get; set; }
        public int FoodId { get; set; }
        public Food Food { get; set; }
        public int FavoriteId { get; set; }
        public Favorite Favorite { get; set; }
        public int FavortiteNumber { get; set; }
    }
}

