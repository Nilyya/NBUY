using DiariesFoodApp.Data.Abstract;
using DiariesFoodApp.Data.Concrete.EfCore.Context;
using DiariesFoodApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiariesFoodApp.Data.Concrete.EfCore.Repositories
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product>, IProductRepository
    {
        public EfCoreProductRepository(DiariesAppContext context) : base(context)
        {

        }
        private DiariesAppContext DiariesAppContext
        {
            get { return _context as DiariesAppContext; }
        }

        public async Task<List<Product>> GetHomePageProductsAsync()
        {
            return await DiariesAppContext
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
