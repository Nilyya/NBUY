using DiariesFoodApp.Data.Config;
using DiariesFoodApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DiariesFoodApp.Data.Concrete.EfCore.Context
{
    public class DiariesAppContext:DbContext
    {
        public class ShopAppContext : DbContext
        {
            public DbSet<Category> Categories { get; set; }
            public DbSet<Product> Products { get; set; }
            public DbSet<ProductCategory> ProductCategories { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite("Data Source=ShoppingApp.db");
            }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.ApplyConfiguration(new CategoryConfig());
                modelBuilder.ApplyConfiguration(new ProductConfig());
                modelBuilder.ApplyConfiguration(new ProductCategoryConfig());
            }
        }
    }
}
