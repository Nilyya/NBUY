﻿using Microsoft.EntityFrameworkCore;
using ShoppingApp.Data.Abstract;
using ShoppingApp.Data.Concrete.EfCore.Contexts;
using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Concrete.EfCore.Repositories
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product>, IProductRepository
    {
        public EfCoreProductRepository(ShopAppContext context):base(context)
        {

        }
        private ShopAppContext ShopAppContext
        {
            get { return _context as ShopAppContext;  }
        }

        public Task CreateProductAsync(Product product, int[] selectedCategoryIds)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> GetHomePageProductsAsync()
        {
            return await ShopAppContext
                .Products
                .Where(p => p.IsHome && p.IsApproved)
                .ToListAsync();
        }

        public Task<Product> GetProductDetailsByUrlAsync(string productUrl)
        {
            return ShopAppContext
                  .Products
                  .Where(p => p.Url == productUrl)
                  .Include(p => p.ProductCategories)
                  .ThenInclude(p => p.Category)
                  .FirstOrDefaultAsync();
        }

        public async Task<List<Product>> GetProductsByCategoryAsync(string category)
        {
            var products= ShopAppContext.Products.AsQueryable();
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

        public async Task<List<Product>> GetProductsWithCategories(int id)
        {
            return await ShopAppContext
                .Products
                .Include(p => p.ProductCategories)
                .ThenInclude(pc => pc.Category)
                .ToListAsync();
        }

        public Task<List<Product>> GetProductsWithCategories()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> GetProductWithCategories()
       {
        return await ShopAppContext
        .Products
        .Include(p=>p.ProductCategories)
        .ThenInclude(pc=>pc.Category)
        .ToListAsync();
       }
public async Task<Product> GetProductWithCategories(int id)
{
    return await ShopAppContext
    .Products
    .Where(p=>p.Id==id)
    .Include(p=>p.ProductCategories)
    .ThenInclude(pc=>pc.Category)
    .FirstOrDefaultAsync();
    }
        public Task UpdateProductAsync(Product product, int[] selectedCategoryIds)
        {
            Product newProduct = await ShopAppContext
                .Products
                .Include(p => p.ProductCategories)
                .FirstOrDefaultAsync(p=>p.Id==product.Id);
            return null;
        }
    }
}
