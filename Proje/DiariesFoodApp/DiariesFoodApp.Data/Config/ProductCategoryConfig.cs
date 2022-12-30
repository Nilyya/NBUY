using DiariesFoodApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiariesFoodApp.Data.Config
{
    public void Configure(EntityTypeBuilder<ProductCategory> builder)
    {
        builder.HasKey(pc => new { pc.ProductId, pc.CategoryId }); 

        builder.ToTable("ProductCategories");

        builder.HasData(
            new ProductCategory { ProductId = 1, CategoryId = 1 },
            new ProductCategory { ProductId = 1, CategoryId = 2 },
            new ProductCategory { ProductId = 1, CategoryId = 4 },
            new ProductCategory { ProductId = 2, CategoryId = 1 },
            new ProductCategory { ProductId = 2, CategoryId = 2 },
            new ProductCategory { ProductId = 2, CategoryId = 3 },
            new ProductCategory { ProductId = 3, CategoryId = 1 },
            new ProductCategory { ProductId = 3, CategoryId = 5 },
            new ProductCategory { ProductId = 3, CategoryId = 6 }
           

       
            );
    }
}
