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
    public class FoodConfig : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Id).ValueGeneratedOnAdd();          
            builder.Property(f => f.Name).IsRequired().HasMaxLength(100);
            builder.Property(f => f.Clue);
            builder.Property(f => f.Repice).IsRequired();
            builder.Property(f => f.Preparation).IsRequired();
            builder.Property(f => f.PreparationTime).IsRequired();
            builder.Property(f => f.BakingTime).IsRequired();
            builder.Property(f => f.Service).IsRequired().HasMaxLength(10);
            builder.Property(f => f.ImageUrl).IsRequired().HasMaxLength(100);
            builder.Property(f => f.Url).IsRequired().HasMaxLength(250);
            builder.ToTable("Foods");
            builder.HasData(
                new Food { Id = 1,IsHome=false, IsApproved = true, Name = "Kurban Eti Kavurması", 
                    Clue = "*Kavurma Kurban Etinin Neresinden Yapılır? Kavurma, koyun ve kuzu etinin but ve kol kısmından,dana etinin ise sırt ve kol-kürek kısmından hazırlanır.\r\n*Kuyruk yağı yerine sıvı yağ kullanabilirsiniz." +
                    "\r\n*Dilerseniz kavurmanızı soğanlı da yapabilirsiniz. Soğanları etleri kavurma esnasında ekleyebilirsiniz.\r\n" +
                    "*Dilerseniz baharat çeşitlerini ve seviyesini tadarak arttırabilirsiniz.\r\n*Mümkünse kurban etini 2-3 gün kadar +4°C’de dinlendirin" +
                    ".\r\n*Kurban Eti Yıkanır mı? Kurban etini hemen kullanacaksanız eğer bol suda güzelce yıkayıp süzdürmeyi ihmal etmeyin.\r\n*Tuz etin" +
                    " sertleşmesine sebep olduğu için tüm baharatları et piştikten sonra eklemeye özen gösterin.", 
                    Repice = "200 g kuyruk yağı\r\n1 kg kuşbaşı kuzu eti\r\nyeteri kadar tuz\r\nyeteri kadar karabiber\r\ntercihen kimyon" +
                    "\r\ntercihen kekik\r\ntercihen pul biber", Preparation = "1\r\nGeniş bir tencereye ince doğranmış kuyruk yağını ekleyip kavurmaya" +
                    " başlayın.\r\n2\r\nYağ erimeye başladığında kuşbaşı doğranmış kuzu etlerini tencereye ekleyin. Etler suyunu çekip salana kadar yüksek" +
                    " ateşte kavurmaya devam edin.\r\n3\r\nDaha sonra kısık ateşe alın. Üzeri kızarıp kahverengi bir görünüm alıncaya ve tamamen suyunu " +
                    "çekinceye kadar kapağı kapalı şekilde pişmeye bırakın. Pişme esnasında ara ara karıştırmayı ihmal etmeyin.\r\n4\r\nEtler yumuşayıp " +
                    "piştikten sonra; tuz, karabiber, kimyon, kekik, pul biber gibi dilediğiniz baharatlarla etinizi lezzetlendirip güzelce karıştırın." +
                    "\r\n5\r\nOcaktan aldığınız kavurmayı, kendi tenceresinde kapağı kapalı olarak yaklaşık 10 dakika dinlendirdikten sonra sıcak olarak" +
                    " servis edebilirsiniz.", 
                    PreparationTime = "2-3 Gün", BakingTime = "60 Dk", Service = "6-8 Kişilik", ImageUrl = "kavurma.jpeg", Url = "kurban-eti-kavurmasi" },
               
                
                
                new Food { Id = 2,IsHome = false, IsApproved = true, Name = "Renkli Soğuk Makarna", 
                    Clue = "*Baharat oranlarını damak zevkinize göre ayarlayabilirsiniz.", 
                    Repice = "200 g haşlanmış renkli makarna\r\n1/4 demet kıyılmış maydanoz\r\n1 adet olgun avokado\r\n4-5 adet çeri domates" +
                    "\r\n100 g top peynir\r\n20 g konserve mısır\r\n20 g dilim zeytin\r\n10 g Hardal\r\n15 g bal\r\nkırmızı toz biber\r\ntuz" +
                    "\r\nkekik", 
                    Preparation = "1\r\nHaşlanmış makarnayı geniş bir karıştırma kabına alın.\r\n2\r\nKıyılmış maydanozu, " +
                    "doğranmış avokadoyu, ikiye bölünmüş çeri domatesleri ve geri kalan tüm malzemeleri ekleyip güzelce karıştırın.\r\n" +
                    "3\r\nSon olarak toz baharatlarla lezzetlendirip servis edin. Afiyet olsun.", 
                    PreparationTime = "30 Dk", BakingTime = "20 Dk", Service = "2 Kişilik", ImageUrl = "renklimakarna.jpeg", Url = "renkli-makarna" },
               
                
                
                new Food { Id = 3,IsHome = true, IsApproved = true, Name = "Fırın Sütlaç", 
                    Clue = "Bu sefer bizim yaptığımız gibi tarifinde küçük bir farklılık yapıp yumurta sarısı ilavesiyle pişirdiğinizde ve porsiyonluk fırın kaplarında pişirme işlemini sürdürdüğünüzde fırın sütlaç göz kırpar size.",
                    Repice = "2\r\nsu bardağı\r\nsu\r\n1\r\nçay bardağı\r\npirinç\r\n5\r\nsu bardağı\r\nsüt\r\n1\r\nsu bardağı\r\ntoz şeker\r\n1\r\nadet\r\nyumurta sarısı\r\n2\r\nyemek kaşığı\r\nbuğday nişastası\r\n1\r\npaket\r\nvanilin\r\n1\r\nsu bardağı\r\nsu" +
                    "\r\n(nişastayı açmak için)",
                    Preparation = "Bol suda yıkadığınız pirinçleri; bir tencerede, 2 su bardağı suyu ekleyerek orta ateşte suyunu çekene kadar haşlayın.\r\nfirin-sutlac15\r\nSoğuk süt ve toz şekeri ayrı bir geniş tencereye alın." +
                    " Bir çırpma teliyle toz şeker eriyene kadar karıştırdıktan sonra ocağa alın. Kısık ateşte kaynamaya bırakın.\r\nfirin-sutlac11\r\nVanilini toz şeker eriğinde süte ekleyin.\r\nfirin-sutlac19\r\nHaşlanan pirinçleri" +
                    " ocaktan alın ve fazla suyu kaldıysa süzün.\r\nfirin-sutlac45\r\n1-2 dakika kadar kaynayan şekerli süte haşlanmış pirinçleri ilave edin.\r\nfirin-sutlac51\r\nYumurta sarısını, buğday nişastası ve 1 bardak su" +
                    " ilavesiyle ayrı bir kabın içerisine alın.\r\nfirin-sutlac63\r\nPürüzsüz bir kıvam alana kadar karıştırın.\r\nfirin-sutlac69\r\nYumurta sarısının kesilmemesi için; kısık ateşte kaynamakta olan süt karışımından alıp" +
                    " nişastalı karışımı ılıştırın.\r\nfirin-sutlac81\r\nHazırladığınız yumurta sarılı karışımı sütlaç tenceresine azar azar katıp hızlıca karıştırın.\r\nfirin-sutlac110\r\nKıvam alan sütlacı, ısıya dayanıklı" +
                    " porsiyonluk güveç kaplarına eşit ölçüde boşaltın.\r\nfirin-sutlac120\r\nSütlaç kaselerini, derin bir fırın tepsisine aralıklı olarak dizin. Kapların yarısına gelecek kadar soğuk suyu, sütlaçlara değdirmeden" +
                    " tepsiye dökün.\r\nfirin-sutlac138\r\nFırına verdiğiniz sütlaçları, önceden ısıtılmış 200 derece fırında 12-15 dakika kadar pişirin.\r\nfirin-sutlac149\r\nFırından bir mutfak eldiveni yardımıyla çıkardığınız" +
                    " sütlaç kaselerini, oda ısısında soğuttuktan sonra buzdolabına kaldırın. Soğuttuktan sonra sevdiklerinizle paylaşın.", 
                    PreparationTime = "30 Dk", BakingTime = "45 Dk", Service = "4 Kişilik", ImageUrl = "firin-sutlac.jpeg", Url = "firin-sutlac" },
               
                
                
                new Food { Id = 4, IsHome = true, IsApproved = true, Name = "Reçelli Kurabiye",
                    Clue = "Kurabiye yapımında kullandığınız malzemeleri oda sıcaklığında kullanmaya dikkat edin.Kurabiyelerin adet sayısı " +
                    "kullandığınız kurabiye kalıplarının büyüklüklerine ve şekillerine göre değişiklik gösterebilir.\r\n\r\n\r\nReçelli Kurabiye " +
                    "Tarifinin Pişirme ",
                    Repice = "100\r\ngram\r\ntereyağı (oda sıcaklığında bekletilmiş)\r\n1\r\nadet\r\nyumurta sarısı\r\n1/2\r\nsu bardağı" +
                    "\r\npudra şekeri\r\n1,5\r\nsu bardağı\r\nun\r\n1/4\r\nçay kaşığı\r\ntoz zencefil\r\nİçi için:\r\n4\r\nyemek kaşığı" +
                    "\r\nçilek reçeli\r\n4\r\nyemek kaşığı\r\nkayısı reçeli\r\nÜzeri için:\r\n2\r\nyemek kaşığı\r\npudra şekeri", 
                    Preparation = "Oda sıcaklığında yumuşayana kadar beklettiğiniz tereyağı, elenmiş pudra şekeri ve yumurta sarısını karıştırma kabına" +
                    " alın.\r\nElinizle krema haline gelene kadar karıştırın. Toz zencefili bu aşamada ekleyin.\r\nElenmiş unu azar azar katıp kurabiye " +
                    "hamurunu kıvam alana kadar yoğurmaya başlayın.\r\nKurabiye hamurunu göz kararı iki eşit parçaya böldükten sonra hafifçe unlanmış " +
                    "mutfak tezgahı üzerinde yaklaşık 1 cm. kalınlığında açın.\r\nKenarları tırtıklı hamur rulosu yardımıyla açtığınız hamurlardan kare " +
                    "parçalar kesin.\r\nKare hamurların orta kısımlarına çay kaşığının ucu yardımıyla çilek ya da kayısı reçeli bırakın. Hamurların kenar" +
                    " kısımlarını ortaya doğru katlayıp reçelli kısım üzerinde birleştirin.\r\nHazırladığınız kurabiyeleri tabanına yağlı kağıt serilmiş " +
                    "fırın tepsisine aralıklı olarak yerleştirin.\r\nKurabiyeleri, önceden ısıtılmış 170 derece fırında yaklaşık 12-15 dakika kadar pişirin." +
                    " Üzerleri hafif bir renk alan kurabiyeleri, fırından çıkardıktan sonra oda ısısında dinlendirin.\r\nÜzerlerine pudra şekeri " +
                    "elediğiniz kurabiyeleri, sevdiklerinizle paylaşın.",
                    PreparationTime = "45 Dk", BakingTime = "15 Dk", Service = "24 Kişilik", ImageUrl = "recelli-kurabiye.jpeg", Url = "recelli-kurabiye" },
               
                
                
                new Food { Id = 5, IsHome = true, IsApproved = true, Name = "Çıtır Milföy Çanağında Lor Salatası",
                    Clue = "Biz içerisine narlı, taze otlu ve cevizli bir lor salatası hazırladık. Siz dilerseniz bu tarifi çeşitlendirebilirsiniz. Nasıl mı? Mesela çikolata kreması, muz ve çilek koyup tatlı olarak ya da içerisine bol yeşillikli bir kısır hazırlayarak bu çanaklarla sunumlar yapabilirsiniz. Hepsinin çok sevileceğine hiç şüphemiz yok! ", Repice = "6\r\nkare\r\nmilföy hamuru\r\n1,5\r\nsu bardağı\r\nlor peyniri\r\n1\r\nçay bardağı\r\ndövülmüş ceviz içi\r\n1\r\navuç\r\ndoğranmış maydanoz\r\n1\r\navuç\r\ndoğranmış dereotu\r\n5\r\nyemek kaşığı\r\nnar tanesi\r\n2\r\nyemek kaşığı\r\ndilimlenmiş siyah zeytin(süslemek için)",
                    Preparation= "Muffin kalıplarının tersini sıvı yağ ile yağlayın.\r\nKare şeklindeki milföy hamurlarını yağladığınız yüzeye kase şeklini vererek yerleştirin ve önceden ısıtılmış 180 derece fırında 20 dakika pişirin.\r\nMilföy hamurları piştikten sonra soğumasını bekleyin ve kalıptan çıkarıp sunum tepsinize yerleştirin.\r\nAyrı bir kasede lor peyniri, dövülmüş ceviz içi, kıyılmış maydanoz, dereotu ve nar tanelerini güzelce karıştırın.\r\nHazırlamış olduğunuz lor peynirli salatayı pişmiş ve soğumuş olan milföy kaselerinin içine paylaştırın.\r\nSalatanın üzerini zeytin dilimleriyle süsleyin ve sevdiklerinizle afiyetle tüketin.",
                    PreparationTime = "10 Dk", BakingTime = "20 Dk", Service = "6 Kişilik", ImageUrl = "lor-salata.jpeg", Url = "lor-salata" },
               
                
                
                new Food { Id = 6, IsHome = true, IsApproved = true, Name = "Sıcak Çikolata", 
                    Clue = "Bitter çikolata yerine damak zevkinize göre sütlü çikolata ekleyebilir ya da yarı oranda katabilirsiniz. Çikolata miktarı için 60 gram klasik kare çikolata paketinin 1/3 oranında eklemeniz yeterli olur.Arzuya göre şeker yerine çikolatayı ekledikten sonra 1 yemek kaşığı bal ekleyebilirsiniz. Farklı aromalar katmak için sütü kaynatırken içerisine tarçın çubuğu ekleyebilirsiniz. ", Repice = "2,5\r\nçay bardağı\r\nsüt\r\n(250 ml)\r\n1\r\nyemek kaşığı\r\nkakao\r\n1\r\ntatlı kaşığı\r\ntoz şeker\r\n(arzuya göre)\r\n20\r\ngram\r\nbitter çikolata", 
                    Preparation = "Bir tencereye sütü ve şekeri ekleyin. Üzerine kakaoyu koyup ocakta sürekli karıştırarak hafif kaynatın.Ocaktan alıp çikolatayı ekleyin ve birkaç dakika çikolataların erimesi için sürekli karıştırın.Sıcak çikolatanızı bardağa doldurun. Arzuya göre üzerine çikolata rendesi ya da marshmallow ekleyerek sıcak sıcak servis edin.", 
                    PreparationTime = "5 Dk", BakingTime = "5 Dk", Service = "1 Kişilik", ImageUrl = "sicak-cikolata.jpeg", Url = "sicak-cikolata" },
                
                
                
                new Food { Id = 7, IsHome = true, IsApproved = true, Name = "Tuzlu Karamel", 
                    Clue = "Kremanın oda sıcaklığında olması sosunuzun kıvamının tam oturması açısından yararlı olacaktır. Kremayı soğuk kullanmak kıvamının kesilmesine neden olabilir. Kremayı ilave ettikten sonra çok fazla ocağın üzerinde tutmamaya gayret gösterin. Çünkü ocaktan aldıktan sonra sosunuzun kıvamı giderek koyulaşacaktır. Sosunuzu ağzı sıkıca kapalı bir biçimde, ıslak kaşık vs değdirmeden 2 hafta kadar saklayabilirsiniz. Eğer deniz tuzunun yoksa normal sofra tuzu kullanarak da tarifimizi deneyebilirsiniz.", 
                    Repice = "225\r\ngram\r\ntoz şeker\r\n(1 + 1/3) su bardağı\r\n125\r\ngram\r\ntereyağı\r\n(soğuk ve küp küp kesilmiş)\r\n1\r\npaket\r\nkrema\r\n1\r\nçay kaşığı\r\ndeniz tuzu",
                    Preparation = "Ocağın altını kısık ateşte açın.\r\nOrta boy bir, kalın tabanlı bir sos tenceresini ocağın üzerine alın. İçerisine toz şekeri ilave edin.\r\nTahta kaşık ya da spatula yardımıyla yapışmamasına ve yanmamasına özen göstererek, karıştıra karıştıra şekerin erimesini sağlayın.\r\nŞeker eridiğinde ve amber rengi aldığında tereyağını ilave edin ve çok hızlı bir biçimde yedirin. Bu aşamada köpürmeler olmaya başlayacak.\r\nKöpürmeler yaşadığınızda ve kıvam koyulaşmaya başladığında kremayı azar azar aktarmaya başlayın.\r\nTüm kremayı karıştırdığınızda ve sos homojen bir hal aldığında ocaktan alın ve içerisine tuzu ilave edin.\r\nGüzelce karıştırdıktan sonra bir kavanozun içerisine aktarın ve ağzı kapalı bir biçimde buzdolabında muhafaza edin.", 
                    PreparationTime = "5 Dk", BakingTime = "15 Dk", Service = "1 Kişilik", ImageUrl = "tuzlu-karamel.jpeg", Url = "tuzlu-karamel" }

                );

        }
    }
}