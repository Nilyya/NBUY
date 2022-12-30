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
        List<Product> GetProductsByCategory();
        Task<List<Product>> GetHomePageProductsAsync();
    }
}
