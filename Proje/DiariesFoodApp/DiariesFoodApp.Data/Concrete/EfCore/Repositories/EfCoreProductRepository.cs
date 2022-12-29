using DiariesFoodApp.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiariesFoodApp.Data.Concrete.EfCore.Repositories
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product>, IProductRepository
    {
        public EfCoreProductRepository(DiariesContext context) : base(context)
        {

        }
        private DiariesAppContext ShopAppContext
        {
            get { return _context as DiariesAppContext; }
        }

        public async Task<List<Product>> GetHomePageProductsAsync()
        {
            return await ShopAppContext
                .Products
                .Where(p => p.IsHome && p.IsApproved)
                .ToListAsync();
        }

        public List<Product> GetProductsByCategory()
        {
            throw new NotImplementedException();
        }
    }
}
