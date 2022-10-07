namespace Proje13_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string adSoyad = "Fatih Candan, Cemal Gündem, Selin Dilci";
            //Console.WriteLine(adSoyad);
            //string ad;
            //string[]adlar = new string[7];//İçinde 7 adet string bilgi tutabilecek bir dizi
            //adlar[0]="Fatih Candan";
            //adlar[1]="Cemal Gündem";
            //adlar[2] = "Selin Dilci";
            //adlar[3] = "Kemal Kurt";
            //adlar[4] = "Begüm Yancı";
            //adlar[5] = "Selma Halıcı";
            //adlar[6] = "Emre Mor";
            ////Console.WriteLine(adlar[0]);

            //for (int i = 0; i < adlar.Length; i++)
            //{
            //    Console.WriteLine(adlar[i]);
            //}

            //int[] yaslar = new int[3];

            //int[] rakamlar = { 56, 89, 90, 45, 33, 55 };
            //int toplam = 0;
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    toplam+=rakamlar[i];
            //}
            //Console.WriteLine(toplam);

            //string okul = "Wissen Akademie";
            //Console.WriteLine(okul[0]);

            // Klavyeden kullanıcının adını soyadını girmesini isteyiniz.
            // Girilen ad soyadı aşağıya doğru Büyük harfle yazdırınız
            //Console.WriteLine("Adınızı giriniz:");
            //string ad = Console.ReadLine().ToUpper();
            //for (int i = 0; i < ad.Length; i++)
            //{
            //    Console.WriteLine(ad[i]);
            //}

            //Console.WriteLine("Bir metin giriniz:");
            //string girilenMetin = Console.ReadLine();
            //Console.WriteLine("Hangi karakterin sırasını bulmamı istersiniz?");
            //string karakter=(Console.ReadLine());
            //int siraNo = girilenMetin.IndexOf(karakter) + 1;
            //Console.Clear();
            //Console.WriteLine($"Girilen Metin:{girilenMetin}\nAradığımız karakter:{karakter}\nAradığınız Karakterin Girilen Metindeki Sırası:{siraNo}");

            //int[] yaslar = new int[3];

            //int[] rakamlar = { 56, 89, 90, 45, 33, 55 };
            //int enBuyuk=rakamlar[0];
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    if(rakamlar[i]>enBuyuk)
            //    {
            //        enBuyuk=rakamlar[i];
            //    }
            //    Console.WriteLine($"{i}.Eleman:\t{rakamlar[i]}");
            //}
            //Console.WriteLine(enBuyuk);

            //Kendimiz en büyük sayıyı buluyoruz


            //Console.WriteLine($"En Küçük:\t{rakamlar.Min()});
            //Console.WriteLine($"En Küçük:\t{rakamlar.Max()});
            // İsteğe Bağlı çalışma bu diziyi küçükten büyüğe sıralayınız.

            //for (int i = 0; i < rakamlar.Length; i++)
            //{

            //    Console.WriteLine($"{i+1}.Eleman:\t{rakamlar[i]}");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Dizinin orjinal hali");
            //Console.WriteLine("***************");
            //Array.Reverse(rakamlar);
            //for (int i = 0; i < rakamlar.Length; i++)
            //{

            //    Console.WriteLine($"{i + 1}.Eleman:\t{rakamlar[i]}");
            //}
            //Console.WriteLine();



            //console.writeline("dizininküçükten büyüğe hali");
            //console.writeline("***************");
            //array.Sort(rakamlar);
            //for (int i = 0; i < rakamlar.length; i++)
            //{

            //    console.writeline($"{i + 1}.eleman:\t{rakamlar[i]}");
            //}
            //console.writeline();


            //Örnekler:
            // Örnek1:dizisi elemanlarının ortalamasını bulup ekrana yazdıralım
            //int[] sayilar = { 5, -16, 8, 12, -15, 78, 90, 0 };
            //int toplam = sayilar.Sum();
            //Console.WriteLine($"Toplam:{toplam}");
            //Örnek2:sayilar dizisindeki çift sayıları ekrana yazdıralım
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i]%2==0)
            //    {
            //        Console.WriteLine(sayilar[i]);
            //    }
            //}
            //Örnek3:sayılar dizisindeki sayıları pozitif,negatif yada işretsiz olma bilgilerini yazdıralım
            //string tip = "";
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    tip = sayilar[i] > 0 ? "Pozitif" : sayilar[i] < 0 ? "Negatif" : "İşaretsiz";
            //    Console.WriteLine($"{i + 1}.Sayı:{sayilar[i]}-Tipi:{tip}");
            //}
            //Örnek4:Kullanıcını gireceği bir metnin içindeki sesli harf sayısını ekrana yazdıralım
            //char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'u', 'ü', 'o', 'ö' };
            //int sesliHarfAdedi = 0;
            //Console.WriteLine("Bir Metin Giriniz:");
            //string girilenMetin = Console.ReadLine().ToLower();
            //for (int i = 0; i < girilenMetin.Length; i++)
            //{
            //    if (sesliHarfler.Contains(girilenMetin[i]))
            //    {
            //        sesliHarfAdedi++;
            //    }

            //}
            //Console.WriteLine(sesliHarfAdedi);
            //Örnek5:Klavyeden girilen bir Cümle'deki yine klavyeden girilecek bir kelimenin kaç kez geçtiğini bulunuz

            int sozcukAdedi = 0;
            Console.WriteLine("Cümleyi giriniz:");
            string girilenCumle = Console.ReadLine();
            Console.WriteLine("Adedini bulmak istediğiniz sözcüğü giriniz:");
            string sayilacakSozcuk=Console.ReadLine();
            string[] girilenCumleninDiziHali = girilenCumle.Split("");
            for (int i = 0; i < girilenCumleninDiziHali.Length; i++)
            {
                if (sayilacakSozcuk.ToLower() == girilenCumleninDiziHali[i].ToString().ToLower())
                {
                    sozcukAdedi++;
                }
            }
            Console.WriteLine($"'{girilenCumle}'cümlesi içinde'{sayilacakSozcuk}'sözcüğü'{sozcukAdedi}'kez geçmektedir");

            //Araştırma Ödevi:Çok boyutlu dizileri araştırın
            //Ödev:Proje //engin.ergu@wissenakademie.com
            //içinde türkçe karakterler haric tüm küçük harfler, sıfır dokuz arası rakamlar, nokta(.), virgül(,), artı(+), eksi(-) karakterleri bulunabilecek toplam uzunluğu 6 karakter olacak şekilde ŞİFRE üreten programı yazınız.
        }
    }
}