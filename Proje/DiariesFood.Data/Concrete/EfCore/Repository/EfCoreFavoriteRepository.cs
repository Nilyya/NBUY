using DiariesFood.Data.Abstract;
using DiariesFood.Data.Concrete.EfCore.Contexts;
using DiariesFood.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiariesFood.Data.Concrete.EfCore.Repository
{
    public class EfCoreFavoriteRepository : EfCoreGenericRepository<Favorite>, IFavoriteRepository
    {
        public EfCoreFavoriteRepository(DiariesFoodContext context) : base(context)
        {
        }

        private DiariesFoodContext DiariesFoodContext
        {
            get { return _context as DiariesFoodContext; }
        }

        public async Task AddToFavorite(string userId, int foodId, int favortiteNumber)
        {
            var favorite = await GetFavByUserId(userId);
            if (favorite != null)
            {
                var index = favorite.FavoriteItems.FindIndex(fi => fi.FoodId == foodId);

                if (index < 0)
                {
                    favorite.FavoriteItems.Add(new FavoriteItem
                    {
                        FoodId = foodId,
                        FavoriteId = favorite.Id,
                        FavortiteNumber = favortiteNumber
                    });
                }
                else
                {
                    favorite.FavoriteItems[index].FavortiteNumber += favortiteNumber;
                }
                DiariesFoodContext.Favorites.Update(favorite);
            }
        }

        public async Task<Favorite> GetFavByUserId(string userId)
        {
            var favorite = await DiariesFoodContext
                .Favorites
                .Include(f => f.FavoriteItems)
                .ThenInclude(fi => fi.Food)
                .FirstOrDefaultAsync(f => f.UserId == userId);
            return favorite;
        }
    }
}