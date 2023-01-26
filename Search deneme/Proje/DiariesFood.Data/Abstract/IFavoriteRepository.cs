using DiariesFood.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiariesFood.Data.Abstract
{
    public interface IFavoriteRepository : IRepository<Favorite>
    {
        Task AddToFavorite(string userId, int foodId, int favortiteNumber);
        Task<Favorite> GetFavByUserId(string userId);
    }
}
