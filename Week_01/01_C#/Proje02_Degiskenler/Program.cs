namespace Proje02_Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir değişkene isim verirken
            //1) Alfanümerik karakterler kullanımaz.(alt tire(_)hariç)
            //2) Türkçe karakter kullanılmaz.(Zorunlu değil)
            //3) Özel ya da ayrılmış sözcükler kullanılmaz.
            //4) Değişeken isimleri küçük büyük harf duyarlıdır.
            /*
            string adSoyad;
            adSoyad = "Alex de Souza";//ctrl+k+u pasifleştir
            Console.WriteLine(adSoyad);
            Console.WriteLine("adSoyad");
            */
            //yıldızla aç kapa pasifleştir.
            /*
             int yas;
             yas = 19;
             Console.WriteLine(yas);

             string adSoyad = "Ahmet Candan";
             Console.WriteLine(adSoyad);
             cw yaz tab + tab yap console.write kısa yol
             Console.WriteLine("Adı:" + adSoyad + ", Yaş" + yas);
            */

            // TAM SAYI
            //Console.WriteLine(byte.MinValue+"-"+byte.MaxValue);

            byte sayi1 = 255;
            int sayi2 = 45;
            long sayi3 = 12548789786546;

           // string sayi4 = "15";
           // Console.WriteLine(sayi4 + 2);

            //ONDALIKLI
            float a=10.5f;
            double b = 20.6d;
            decimal c = 100.65m;// parasal değer için

            //KARAKTER ve METİN
            string name = "Aylin Aydemir";
            char cinsiyet = 'K';//içinde sadece tek bir karakter tutabilen bir tip tek tırnakla yaz

            //MANTIKSAL
            bool evliMi = true;
            evliMi = false;

        }
    }
}