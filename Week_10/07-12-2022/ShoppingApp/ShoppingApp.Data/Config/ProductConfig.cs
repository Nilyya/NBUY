using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);

            builder.Property(p=>p.Description).IsRequired().HasMaxLength(500);

            builder.Property(p => p.ImageUrl).IsRequired().HasMaxLength(250);

            builder.Property(p => p.Url).IsRequired().HasMaxLength(250);

            builder.Property(p=>p.DateAdded).HasDefaultValueSql("date('now')");

            builder.ToTable("Products");

            builder.HasData(
                new Product { Id=1, Name="Samsung S20", Price=24500, Description="Kamerası son teknoloji", ImageUrl="1.png", Url="samsung-s20",IsHome=true,IsApproved=true},


            new Product { Id = 2, Name = "Samsung S21", Price = 34500, Description = "Kamerası son teknoloji,5G", ImageUrl = "2.png", Url = "samsung-s21", IsHome = false, IsApproved = true },


             new Product { Id = 3, Name = "Iphone 13", Price = 21500, Description = "Güzel bir telefon", ImageUrl = "3.png", Url = "iphone-13", IsHome = true, IsApproved = true },


            new Product { Id = 4, Name = "Iphone 14 Pro", Price = 34500, Description = "Kamerası son teknoloji", ImageUrl = "4.png", Url = "iphone-14-pro", IsHome = true, IsApproved = true }, 
            
            new Product { Id = 5, Name = "I Pad 12", Price = 24500, Description = "Kamerası son teknoloji", ImageUrl = "5.png", Url = "i-pad-12", IsHome = true, IsApproved = false },

            new Product { Id = 6, Name = "Type C Usb Bağlantı Kablosu", Price = 400, Description = "1.5 metre", ImageUrl = "6.png", Url = "type-c-usb-baglantı-kablosu", IsHome = false, IsApproved = true },
            
            new Product { Id = 7, Name = "Vestel Cm123", Price = 9500, Description = "Tam otamatik çamaşır makinası", ImageUrl = "7.png", Url = "vestel-cm123", IsHome = true, IsApproved = true },


             new Product { Id = 8, Name = "Arçelik Türk Kahvesi Makinesi TK8", Price = 24500, Description = "Köpüklü Türk Kahvesi keyfi", ImageUrl = "8.png", Url = "arcelik-turk-kahvesi-makinesi-tk8", IsHome = true, IsApproved = true },
            
             new Product { Id = 9, Name = "MacBook Air M2", Price = 29500, Description = "M2 işlemcinin gücü", ImageUrl = "9.png", Url = "macbook-air-m2", IsHome = false, IsApproved = true }, 
             
             new Product { Id = 10, Name = "Asus Tulbar G45", Price = 26500, Description = "I9 işlemci", ImageUrl = "10.png", Url = "asus-tulbar-g45", IsHome = false, IsApproved = true },
            
             
             new Product { Id = 11, Name = "Lenova K234", Price = 19000, Description = "İş için ideal", ImageUrl = "11.png", Url = "lenove-k234", IsHome = false, IsApproved = true }, 
             
             
             new Product { Id = 12, Name = "Samsung NF34 Buzdolabı", Price = 13000, Description = "Derin donduruculu", ImageUrl = "12.png", Url = "samsung-nf34-buzdolabı", IsHome = false, IsApproved = false}
            


            );

        }
    }
}
