using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiariesFoodApp.Entity.Concrete;

namespace DiariesFoodApp.Business.Abstract
{
    public interface IProductService
    {
        Task<Product> GetByIdAsync(int id);
        Task<List<Product>> GetAllAsync();
        Task CreateAsync(Product product);
        Task CreateFoodAsync(Product product, int[] selectedCategoryIds);
        void Update(Product product);
        Task UpdateFoodAsync(Product product, int[] selectedCategoryIds);
        void Delete(Product product);
        Task<List<Product>> GetFoodsByCategoryAsync(string category);
        Task<List<Product>> GetHomePageFoodsAsync();
        Task<Product> GetFoodDetailsByUrlAsync(string foodUrl);
        Task<List<Product>> GetFoodsWithCategories();
        Task<Product> GetFoodWithCategories(int id);
        Task UpdateIsHomeAsync(Product product);
        Task UpdateIsApprovedAsync(Product product);
        Task<List<Product>> GetProductsByCategoryAsync(string categoryurl);
    }
}