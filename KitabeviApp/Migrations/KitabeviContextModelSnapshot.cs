﻿// <auto-generated />
using KitabeviApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KitabeviApp.Migrations
{
    [DbContext(typeof(KitabeviContext))]
    partial class KitabeviContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.11");

            modelBuilder.Entity("KitabeviApp.Models.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Aciklama")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ad")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Kategoriler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Aciklama = "Çocuk Kitapları",
                            Ad = "Çocuk"
                        },
                        new
                        {
                            Id = 2,
                            Aciklama = "Roman, Hikaye, Şiir Kitapları",
                            Ad = "Edebiyat"
                        },
                        new
                        {
                            Id = 3,
                            Aciklama = "Bilgisayar Kitapları",
                            Ad = "Bilgisayar"
                        },
                        new
                        {
                            Id = 4,
                            Aciklama = "Akademik Kitaplar",
                            Ad = "Akademik"
                        });
                });

            modelBuilder.Entity("KitabeviApp.Models.Kitap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ad")
                        .HasColumnType("TEXT");

                    b.Property<int>("BasimYili")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KategoriId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SayfaSayisi")
                        .HasColumnType("INTEGER");

                    b.Property<int>("YazarId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.HasIndex("YazarId");

                    b.ToTable("Kitaplar");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ad = "İnsanlar",
                            BasimYili = 2021,
                            KategoriId = 2,
                            SayfaSayisi = 330,
                            YazarId = 1
                        },
                        new
                        {
                            Id = 2,
                            Ad = "Zamanı Durdurmanın Yolları",
                            BasimYili = 2021,
                            KategoriId = 1,
                            SayfaSayisi = 370,
                            YazarId = 1
                        },
                        new
                        {
                            Id = 3,
                            Ad = "Demir Ökçe",
                            BasimYili = 2017,
                            KategoriId = 2,
                            SayfaSayisi = 400,
                            YazarId = 4
                        },
                        new
                        {
                            Id = 4,
                            Ad = "Huzursuzluk",
                            BasimYili = 2018,
                            KategoriId = 2,
                            SayfaSayisi = 330,
                            YazarId = 9
                        },
                        new
                        {
                            Id = 5,
                            Ad = "Serenad",
                            BasimYili = 2020,
                            KategoriId = 2,
                            SayfaSayisi = 300,
                            YazarId = 9
                        },
                        new
                        {
                            Id = 6,
                            Ad = "19",
                            BasimYili = 2016,
                            KategoriId = 2,
                            SayfaSayisi = 380,
                            YazarId = 6
                        },
                        new
                        {
                            Id = 7,
                            Ad = "C# Programlama Dili",
                            BasimYili = 2011,
                            KategoriId = 3,
                            SayfaSayisi = 730,
                            YazarId = 7
                        },
                        new
                        {
                            Id = 8,
                            Ad = "React Uygulama Geliştirme",
                            BasimYili = 2021,
                            KategoriId = 3,
                            SayfaSayisi = 530,
                            YazarId = 3
                        },
                        new
                        {
                            Id = 9,
                            Ad = "İnsan Ömrünü Neyle Geçirmeli?",
                            BasimYili = 2021,
                            KategoriId = 2,
                            SayfaSayisi = 330,
                            YazarId = 8
                        });
                });

            modelBuilder.Entity("KitabeviApp.Models.Yazar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ad")
                        .HasColumnType("TEXT");

                    b.Property<char>("Cinsiyet")
                        .HasColumnType("TEXT");

                    b.Property<int>("DogumYili")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Yazarlar");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ad = "Matt Heig",
                            Cinsiyet = 'E',
                            DogumYili = 1980
                        },
                        new
                        {
                            Id = 2,
                            Ad = "Feyyaz Yiğit",
                            Cinsiyet = 'E',
                            DogumYili = 1990
                        },
                        new
                        {
                            Id = 3,
                            Ad = "Gizem Doğan",
                            Cinsiyet = 'K',
                            DogumYili = 1960
                        },
                        new
                        {
                            Id = 4,
                            Ad = "Jack London",
                            Cinsiyet = 'E',
                            DogumYili = 1930
                        },
                        new
                        {
                            Id = 5,
                            Ad = "Margaret Atwood",
                            Cinsiyet = 'K',
                            DogumYili = 1980
                        },
                        new
                        {
                            Id = 6,
                            Ad = "Cem Akaş",
                            Cinsiyet = 'E',
                            DogumYili = 1980
                        },
                        new
                        {
                            Id = 7,
                            Ad = "Zafer Demirkol",
                            Cinsiyet = 'E',
                            DogumYili = 1980
                        },
                        new
                        {
                            Id = 8,
                            Ad = "İlber Ortaylı",
                            Cinsiyet = 'E',
                            DogumYili = 1980
                        },
                        new
                        {
                            Id = 9,
                            Ad = "Seda Yiğit",
                            Cinsiyet = 'K',
                            DogumYili = 1980
                        },
                        new
                        {
                            Id = 10,
                            Ad = "George Orwell",
                            Cinsiyet = 'E',
                            DogumYili = 1980
                        });
                });

            modelBuilder.Entity("KitabeviApp.Models.Kitap", b =>
                {
                    b.HasOne("KitabeviApp.Models.Kategori", "Kategori")
                        .WithMany()
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KitabeviApp.Models.Yazar", "Yazar")
                        .WithMany()
                        .HasForeignKey("YazarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");

                    b.Navigation("Yazar");
                });
#pragma warning restore 612, 618
        }
    }
}
