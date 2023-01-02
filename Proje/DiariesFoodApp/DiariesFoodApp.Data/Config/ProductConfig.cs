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
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.Clue)                
                .HasMaxLength(500);

            builder.Property(p => p.Recipe)
                .IsRequired();

            builder.Property(p => p.Preparation)
               .IsRequired();

            builder.Property(p => p.PreparationTime)
              .IsRequired();

            builder.Property(p => p.BakingTime);
              

            builder.Property(p => p.Service)
              .IsRequired();

            builder.Property(p => p.ImageUrl)
              .IsRequired();

            builder.Property(p => p.Url)
              .IsRequired();

            builder.ToTable("Products");

            builder.HasData(
                new Product { Id = 1, Name = "Kurutulmuş Boşnak Eti", Clue = "", Recipe = "5 g kişniş tohumu\r\n5 g dereotu tohumu\r\n5 g fesleğen tohumu\r\n5 g tane kırmızı biber\r\n200 g tuz\r\n100 g toz şeker\r\n200 g dana antrikot\r\n5 adet tütsülemek için kuru defne yaprağı", Preparation = "1\r\nBütün tane tohumları tavada yüksek ısıda roast ediyoruz. Bu işlemde tamamen kontrollü olmamız gerekmektedir. Fazla roast etmemiz yakmamıza sebep olabilir. Çıtırdama sesleri ve kokusunda değişiklik fark ettiğiniz vakit ocaktan alıp soğutuyoruz.\r\n2\r\nArdından roast ettiğimiz ürünleri mixer ile toz haline getiriyoruz. Tuz ve toz şekeri bu karışıma ekleyerek kür dediğimiz ürünümüzü elde ediyoruz.\r\n3\r\nDana antrikot etin her tarafını iyice ovalayarak bu kürümüzü yediriyoruz. Daha hızlı olgunlaşmasını isterseniz kürdan ile delikler açabilirsiniz. Her tarafına iyice yedirdikten sonra +4 derece dolapta üzerine ağırlık koyarak 3 gün dinlenmeye bırakıyoruz.\r\n4\r\nBu süreçte kür, eti pişirmeye başlayacaktır ve buna istinaden ette su kaybı yaşanacaktır. Onun için dolapta altına bir tepsi koymanız yere akmamasını sağlayacaktır.\r\n5\r\n3 günün ardından üzerindeki ağırlığı alıp 1 hafta bu sürece devam ediyoruz. Süreci ne kadar uzun tutarsanız etin olgunlaşması daha fazla olacaktır. Bu süreci de geçirdikten sonra etin üzerindeki kürü yıkayarak temizliyoruz.\r\n6\r\nSonraki sürecimiz tütsülemek. Ben defne yaprağı kullanıyorum, farklı ürünler örneğin biberiye, kekik, ağaç talaşları gibi ürünler ile de farklı aromalar katabilirsiniz. Tütsü makinanız var ise onunla, konveksiyonel fırınınız var ise 30 derece sabit ısıda fan açık pozisyonda köz yaparak 1 saatte bu işlemi tamamlayabilirsiniz.\r\n7\r\nTütsüleme sonrası etinizi dolapta saklayarak istediğiniz şekilde keserek kullanabilirsiniz.", PreparationTime = "60 Dk", BakingTime = "", Service = "1", ImageUrl = "KurutulmusBosnakEti", Url = "kurutulmus-bosnaketi" },
                new Product { Id = 2, Name = "Kuzu Mutancana", Clue = "*Kuru yemiş ve badem oranını artırıp azaltabilirsiniz.\r\n*Baharat oranını damak zevkinize göre ayarlayabilirsiniz.", Recipe = "20 g Tereyağı\r\n300 g kuzu eti\r\n4 adet arpacık soğan\r\n3 diş sarımsak\r\n20 g un\r\n150 ml et suyu\r\n120 ml içme suyu\r\n15 g kabuksuz çiğ badem\r\n4 adet kuru incir\r\n10 adet sultaniye üzümü\r\n10 g kuru sarı üzüm\r\n5 g sumak\r\n5 g bal\r\n5 g tuz", Preparation = "1\r\nTereyağını tencerede eritin, yanmasın diye az miktarda sıvı yağ ekleyebilirsiniz.\r\n2\r\nKuzu etini iri parçalar halinde kesip, eriyen tereyağında mühürlemeye başlayın. Etler yarı yarıya kızardığında soyulmuş (ikiye kesilmiş) arpacık soğanları ve bütün sarımsakları ekleyip soteleme işlemine devam edin.\r\n3\r\nKızaran etlere unu ilave edin ve karıştırın, et suyu ve içme suyunu koyun. Kaynayana kadar açık ateşte, kaynadıktan sonra kısık ateşte kapağı kapalı şekilde 20-25 dakika pişmeye bırakın.\r\n4\r\nBu esnada ayrı bir tavada bir yemek kaşığı tereyağı eritin, çiğ bademleri renk alana kadar kavurup ocaktan alın. Kuru incirleri ve üzümleri eşit boylarda irice doğrayıp bademlere ekleyin.\r\n5\r\nTencerede pişen yemeği ocaktan aldıktan sonra sumak, bal ve tuz ile lezzetlendirip güzelce karıştırın.\r\n6\r\nServis etmeden önce üzerini kavrulmuş badem ve kuru yemişlerle süsleyin.", PreparationTime = "25 Dk", BakingTime = "25 Dk", Service = "2", ImageUrl = "KuzuMuhtanca", Url = "kuzu-muhtanca" },
                new Product { Id = 3, Name = "Tavuklu Sultan Kebabı", Clue = "*Milföy yerine 1 adet yufka kullanabilirsiniz.\r\n*Baharat oranını damak zevkinize göre ayarlayabilirsiniz.", Recipe = "1 adet havuç\r\n1 adet patates\r\n50 g tane bezelye\r\n1 adet kuru soğan\r\n60 ml zeytinyağı\r\n200-250 g tavuk göğsü\r\n15 g domates salçası\r\n7-8 g tuz\r\nkarabiber\r\nkimyon\r\n4 adet Milföy Hamuru\r\nBeşamel Sos için:\r\n25 g un\r\n25 g Tereyağı\r\n200 ml Krema\r\nyeteri kadar tuz\r\nÜzeri için:\r\n100 g Kaşar Peyniri\r\n", Preparation = "", PreparationTime = "60 Dk", BakingTime = "40 Dk", Service = "4", ImageUrl = "tavuklu-sultan-kebabi", Url = "tavuklu-sultan-kebabi" });
               
        }
    }
}
