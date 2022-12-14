using ShoppingApp.Data.Abstract;
using ShoppingApp.Data.Concrete.EfCore.Contexts;
using ShoppingApp.Entity.Concrete;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Concrete.EfCore.Repositories
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product>, IProductRepository
    {
        public EfCoreProductRepository(ShopAppContext context) : base(context)
        { 

        }
        private ShopAppContext shopAppContext { get
            {
                return _context as ShopAppContext;
            } }
        public async Task<List<Product>> GetHomePageProductsAsync()
        {
            return await ShopAppContext
                .Products
                .Where(p=>p.IsHome && p.IsApproved)
                .ToListAsync();
        }

        public List<Product> GetProductsByCategory()
        {
            throw new NotImplementedException();
        }
    }
}
