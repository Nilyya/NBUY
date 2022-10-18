using System.Reflection.Emit;

namespace Proje14_Value_Reference_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 45;
            int b = a * 2;

            Random rnd=new Random();

            Kisi kisi1 = new Kisi();
            kisi1.Ad = "Engin";
            kisi1.Yas = 47;
            kisi1.Meslek = "Software Developer";

            Kisi kisi2=new Kisi();
            kisi2.Ad = "Saliha";
            kisi2.Yas = 40;
            kisi2.Meslek = "Eğitmen";

            Kisi kisi3=new Kisi();
            kisi3.Ad = "Cemal";
            kisi3.Yas = 66;
            kisi3.Meslek = "Şair";
            Araba araba1=new Araba();
            araba1.Marka = "Opel";
            araba1.Renk = "Mavi";

            DateTime bugun=DateTime.Now;
            Random rnd2=new Random();
        }
        class Kisi
        {
            public string? Ad { get; set; }
            public int Yas { get; set; }
            public string? Meslek { get; set; }

        }
        class Araba
        {
            public string Marka { get; set; }
            public string Renk { get; set; }
           private string VitesTuru { get; set; }
            //Erişim bellirleyeci:Bir property'nin dışından yani içinde buunduğu clasın dışından erişim seviyesini bellirleyen anahtar sözcüklere denir.
            //herhangi bellirlenmemişe privete olur
            //Erişim Bellirleyiciler
            //public, private, internal, protected
        }
    }
}