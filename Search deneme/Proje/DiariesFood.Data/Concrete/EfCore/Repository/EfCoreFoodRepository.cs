using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiariesFood.Data.Abstract;
using DiariesFood.Data.Concrete.EfCore.Contexts;
using DiariesFood.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DiariesFood.Data.Concrete.EfCore.Repository
{
    public class EfCoreFoodRepository : EfCoreGenericRepository<Food>, IFoodRepository
    {
        public EfCoreFoodRepository(DiariesFoodContext context) : base(context)
        {

        }
        private DiariesFoodContext DiariesFoodContext
        {
            get { return _context as DiariesFoodContext; }

        }

        public async Task CreateFoodAsync(Food food, int[] selectedCategoryIds)
        {
            await DiariesFoodContext.Foods.AddAsync(food);
            await DiariesFoodContext.SaveChangesAsync();
            food.FoodCategories = selectedCategoryIds
                .Select(ctId => new FoodCategory
                {

                    FoodId = food.Id,
                    CategoryId = ctId
                }).ToList();
            await DiariesFoodContext.SaveChangesAsync();

        }

        public Task<Food> GetFoodDetailsByUrlAsync(string foodUrl)
        {
            return DiariesFoodContext
                .Foods
                .Where(f => f.Url == foodUrl)
                .Include(f => f.FoodCategories)
                .ThenInclude(fc => fc.Category)
                .FirstOrDefaultAsync();
        }

        public async Task<List<Food>> GetFoodsByCategoryAsync(string category)
        {
            var foods = DiariesFoodContext.Foods.AsQueryable();
            if (category != null)
            {
                foods = foods
                    .Where(f => f.IsApproved)
                    .Include(f => f.FoodCategories)
                    .ThenInclude(fc => fc.Category)
                    .Where(f => f.FoodCategories.Any(fc => fc.Category.Url == category));

            }
            return await foods.ToListAsync();

        }

        public async Task<List<Food>> GetFoodsWithCategories()
        {
            return await DiariesFoodContext
                .Foods
                .Include(f => f.FoodCategories)
                .ThenInclude(fc => fc.Category)
                .ToListAsync();
        }

        public async Task<Food> GetFoodWithCategories(int id)
        {
            return await DiariesFoodContext
                 .Foods
                 .Where(f => f.Id == id)
                 .Include(f => f.FoodCategories)
                 .ThenInclude(fc => fc.Category)
                 .FirstOrDefaultAsync();
        }

        public async Task<List<Food>> GetHomePageFoodsAsync()
        {
            return await DiariesFoodContext
                  .Foods
                  .Where(f => f.IsHome && f.IsApproved)
                  .ToListAsync();
        }

        public Task<List<Food>> GetSearchResultsAsync(Expression<Func<Food, bool>> predicate)
        {
            return null;
        }

        public async Task UpdateFoodAsync(Food food, int[] selectedCategoryIds)
        {
            Food newFood = await DiariesFoodContext
                .Foods
                .Include(f => f.FoodCategories)
                .FirstOrDefaultAsync(f => f.Id == food.Id);

            newFood.FoodCategories = selectedCategoryIds
              .Select(ctId => new FoodCategory
              {
                  FoodId = newFood.Id,
                  CategoryId = ctId
              }).ToList();

            DiariesFoodContext.Update(newFood);
            await DiariesFoodContext.SaveChangesAsync();
        }

        public async Task UpdateIsApprovedAsync(Food food)
        {
            food.IsApproved = !food.IsApproved;
            DiariesFoodContext.Update(food);
            await DiariesFoodContext.SaveChangesAsync();
        }

        public async Task UpdateIsHomeAsync(Food food)
        {
            food.IsHome = !food.IsHome;
            DiariesFoodContext.Update(food);
            await DiariesFoodContext.SaveChangesAsync();
        }
    }
}