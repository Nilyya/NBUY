using DiariesFood.Data.Config;
using DiariesFood.Data.ExtensionPath;
using DiariesFood.Entity.Concrete;
using DiariesFood.Entity.Concrete.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiariesFood.Data.Concrete.EfCore.Contexts
{
    public class DiariesFoodContext : IdentityDbContext<User, Role, string>
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Food> Foods{get;set;}
        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<FavoriteItem> FavoriteItems { get; set; }


        public DiariesFoodContext(DbContextOptions<DiariesFoodContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.SeedData();
            modelBuilder.ApplyConfiguration(new FoodConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new FoodCategoryConfig());
            base.OnModelCreating(modelBuilder);
        }

    }
}

