using DiariesFoodApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiariesFoodApp.Business.Abstract
{
    public interface IProductService
    {
        Task<Product> GetByIdAsync(int id);
        Task<List<Product>> GetAllAsync();
        Task CreateAsync(Product product);
        void Update(Product product);
        void Delete(Product product);
        List<Product> GetProductsByCategory();
        Task<List<Product>>GetHomePageProductsAsync();
    }
}
