using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using DiariesFood.Entity.Concrete;

namespace DiariesFood.Data.Config
{
    public class FoodCategoryConfig : IEntityTypeConfiguration<FoodCategory>
    {
        public void Configure(EntityTypeBuilder<FoodCategory> builder)
        {
            builder.HasKey(fc => new { fc.FoodId, fc.CategoryId });

            builder.ToTable("FoodCategory");

            builder.HasData(
                new FoodCategory { FoodId = 1, CategoryId = 1 },
                new FoodCategory { FoodId = 2, CategoryId = 4 }, 
                new FoodCategory { FoodId = 3, CategoryId = 9 }, 
                new FoodCategory { FoodId = 4, CategoryId = 3 }, 
                new FoodCategory { FoodId = 5, CategoryId = 5}, 
                new FoodCategory { FoodId = 6, CategoryId = 8 }, 
                new FoodCategory { FoodId = 7, CategoryId = 6 }
           );
        }
    }
}