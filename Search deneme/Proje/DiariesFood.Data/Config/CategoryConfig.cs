using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiariesFood.Entity.Concrete;

namespace DiariesFood.Data.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(c => c.Url)
                .IsRequired()
                .HasMaxLength(250);

            builder.ToTable("Categories");

            builder.HasData(

            new Category { Id = 1, Name = "Et", Description = "Et Tarifleri", Url = "et" },
            new Category { Id = 2, Name = "Fast Food", Description = "Fast Food Tarifleri", Url = "fast-food" },
            new Category { Id = 3, Name = "Hamur İşi", Description = "Hamur İşi Tarifleri", Url = "hamur-isi" },
            new Category { Id = 4, Name = "Pilav,Makarna ve Rissotto", Description = "Pilav,Makarna ve Rissotto Tarifleri", Url = "pilav-makarna-rissoto" },
            new Category { Id = 5, Name = "Meze", Description = "Meze Tarifleri", Url = "meze" },
            new Category { Id = 6, Name = "Sos ve Krema", Description = "Sos ve Krema Tarifleri", Url = "sos-ve-krema" },
            new Category { Id = 7, Name = "Çorba", Description = "Çorba Tarifleri", Url = "corba" },
            new Category { Id = 8, Name = "İçecek", Description = "içecek Tarifleri", Url = "icecek" },
            new Category { Id = 9, Name = "Tatlı", Description = "Tatlı Tarifleri", Url = "tatli" });

        }
    }
}