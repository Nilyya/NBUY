using DiariesFoodApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiariesFoodApp.Data.Config
{
    public class CategoryConfig: IEntityTypeConfiguration<Category>
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
                new Category { Id = 1, Name = "Et", Description = "Et ürünleri kategorisi.", Url = "et" },
                new Category { Id = 2, Name = "Kırmızı Et", Description = "Kırmızı et ürünleri kategorisi.", Url = "kirmizi-et" },
                new Category { Id = 3, Name = "Kuzu", Description = "Kuzu eti.", Url = "kuzu" },
                new Category { Id = 4, Name = "Dana", Description = "Dana eti.", Url = "dana-eti" },
                new Category { Id = 5, Name = "Beyaz Et", Description = "Beyaz et ürünleri", Url = "beyaz-et" },
                new Category { Id = 6, Name = "Tavuk", Description = "Tavuk tarifler", Url = "tavuk" },
                new Category { Id = 7, Name = "Hindi", Description = "Hindi tarifleri", Url = "hindi" },
                new Category { Id = 8, Name = "Deniz Ürünleri", Description = "Deniz Ürünleri", Url = "deniz-urunleri" },
                new Category { Id = 9, Name = "Kabuklular", Description = "Kabuklular", Url = "kabuklular" },
                new Category { Id = 10, Name = "Balıklar", Description = "Balıklar", Url = "baliklar" },
                new Category { Id = 11, Name = "FastFood", Description = "FastFood", Url = "fastfood" },
                new Category { Id = 12, Name = "Makarna", Description = "Makarna", Url = "makarna" },
                new Category { Id = 13, Name = "Hamur İşi", Description = "Hamur İşi", Url = "hamur-isi" },
                new Category { Id = 14, Name = "Kurabiye", Description = "Kurabiye", Url = "kurabiye" },
                new Category { Id = 15, Name = "Tartlar", Description = "Tartlar", Url = "tartlar" },
                new Category { Id = 16, Name = "Poğaça", Description = "Poğaça", Url = "pogaca" },
                new Category { Id = 17, Name = "Börek", Description = "Börek", Url = "borek" },
                new Category { Id = 18, Name = "Curumble", Description = "Curumble", Url = "curumble" },
                new Category { Id = 19, Name = "Kek", Description = "Kek", Url = "kek" },
                new Category { Id = 20, Name = "Pilav ve Rissoto", Description = "Pilav ve Rissoto", Url = "pilav-ve-rissoto" },
                new Category { Id = 21, Name = "Meze", Description = "Meze", Url = "meze" },
                new Category { Id = 22, Name = "Sıcak Meze", Description = "Sıcak Meze", Url = "sıcak-meze" },
                new Category { Id = 23, Name = "Soğuk Meze", Description = "Soğuk Meze", Url = "soguk-meze" },
                new Category { Id = 24, Name = "Sos ve Kremalar", Description = "Sos ve Kremalar", Url = "sos-ve-kremalar" },
                new Category { Id = 25, Name = "Çorba", Description = "Çorba", Url = "corba" },
                new Category { Id = 26, Name = "Kahvaltı", Description = "Kahvaltı", Url = "kahvaltı" },
                new Category { Id = 27, Name = "Salata", Description = "Salata", Url = "salata" },
                new Category { Id = 28, Name = "Tatlı", Description = "Tatlı", Url = "tatlı" },
                new Category { Id = 29, Name = "Şerbetli Tatlılar", Description = "Şerbetli Tatlılar", Url = "serbetli-tatlilar" },
                new Category { Id = 30, Name = "Pasta", Description = "Pasta", Url = "pasta" },
                new Category { Id = 31, Name = "Ekler", Description = "Ekler", Url = "ekler" },
                new Category { Id = 32, Name = "Profitorol", Description = "Profitorol", Url = "profitorol" },
                new Category { Id = 33, Name = "Sütlü Tarifler", Description = "Sütlü Tarifler", Url = "sutlu-tatlılar" },
                new Category { Id = 34, Name = "İçecekler", Description = "İçecekler", Url = "icecekler" },
                new Category { Id = 35, Name = "Alkolü", Description = "Alkolü", Url = "alkolu" },
                new Category { Id = 36, Name = "Alkolsüz", Description = "Alkolsüz", Url = "alkolsuz" },
                new Category { Id = 37, Name = "Sarma ve Dolma", Description = "Sarma ve Dolma", Url = "sarma-ve-dolma" },
                new Category { Id = 38, Name = "Tencere Yemekleri", Description = "Tencere Yemekleri", Url = "tencere-yemekleri" },
                new Category { Id = 39, Name = "Zeytinyağlı", Description = "Zeytinyağlı yemekler", Url = "zeytinyaglı" },
                new Category { Id = 40, Name = "Etli", Description = "Etli tencere yemekleri", Url = "etli" });


        }
    }
}
