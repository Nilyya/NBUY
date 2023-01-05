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
        public async Task CreateProductAsync(Product product, int[] selectedCategoryIds)
        {
            await DiariesAppContext.Products.AddAsync(product);
            await DiariesAppContext.SaveChangesAsync();
            product.ProductCategories = selectedCategoryIds
                .Select(ctId => new ProductCategory
                {

                    ProductId = product.Id,
                    CategoryId = ctId
                }).ToList();
            await DiariesAppContext.SaveChangesAsync();

        }
        public Task<Product> GetProductDetailsByUrlAsync(string productUrl)
        {
            return DiariesAppContext
                .Products
                .Where(p => p.Url == productUrl)
                .Include(p => p.ProductCategories)
                .ThenInclude(pc => pc.Category)
                .FirstOrDefaultAsync();
        }
        public async Task<List<Product>> GetProductsByCategoryAsync(string category)
        {
            var products = DiariesAppContext.Products.AsQueryable();
            if (category != null)
            {
                products = products
                    .Where(p => p.IsApproved)
                    .Include(p => p.ProductCategories)
                    .ThenInclude(pc => pc.Category)
                    .Where(p => p.ProductCategories.Any(pc => pc.Category.Url == category));

            }
            return await products.ToListAsync();

        }

        public async Task<List<Product>> GetProductsWithCategories()
        {
            return await DiariesAppContext
                .Products
                .Include(p => p.ProductCategories)
                .ThenInclude(pc => pc.Category)
                .ToListAsync();
        }

        public async Task<Product> GetProductWithCategories(int id)
        {
            return await DiariesAppContext
                 .Products
                 .Where(p => p.Id == id)
                 .Include(p => p.ProductCategories)
                 .ThenInclude(pc => pc.Category)
                 .FirstOrDefaultAsync();
        }
        public async Task<List<Product>> GetHomePageProductsAsync()
        {
            return await DiariesAppContext
                .Products
                .Where(p => p.IsHome && p.IsApproved)
                .ToListAsync();
        }
        public async Task UpdateProductAsync(Product product, int[] selectedCategoryIds)
        {
            Product newProduct = await DiariesAppContext
                .Products
                .Include(p => p.ProductCategories)
                .FirstOrDefaultAsync(p => p.Id == product.Id);

            newProduct.ProductCategories = selectedCategoryIds
              .Select(ctId => new ProductCategory
              {
                  ProductId = newProduct.Id,
                  CategoryId = ctId
              }).ToList();

            DiariesAppContext.Update(newProduct);
            await DiariesAppContext.SaveChangesAsync();

        }

        public async Task UpdateIsApprovedAsync(Product product)
        {
            product.IsApproved = !product.IsApproved;
            DiariesAppContext.Update(product);
            await DiariesAppContext.SaveChangesAsync();
        }

        public async Task UpdateIsHomeAsync(Product product)
        {
            product.IsHome = !product.IsHome;
            DiariesAppContext.Update(product);
            await DiariesAppContext.SaveChangesAsync();
        }

        public Task CreateFoodAsync(Product product, int[] selectedCategoryIds)
        {
            throw new NotImplementedException();
        }

        public Task UpdateFoodAsync(Product product, int[] selectedCategoryIds)
        {
            throw new NotImplementedException();
        }
    }
}
