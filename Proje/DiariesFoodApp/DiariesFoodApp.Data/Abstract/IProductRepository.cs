using DiariesFoodApp.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiariesFoodApp.Entity.Concrete;

namespace DiariesFoodApp.Data.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<List<Product>> GetProductsByCategoryAsync(string category);//Kategoriye göre yemek
        Task<List<Product>> GetHomePageProductsAsync();//anasayfa ürünleri
        Task<Product> GetProductDetailsByUrlAsync(string productUrl);
        Task<List<Product>> GetProductsWithCategories();
        Task CreateFoodAsync(Product product, int[] selectedCategoryIds);
        Task<Product> GetProductWithCategories(int id);
        Task UpdateFoodAsync(Product product, int[] selectedCategoryIds);
        Task UpdateIsHomeAsync(Product product);
        Task UpdateIsApprovedAsync(Product product);
    }
}