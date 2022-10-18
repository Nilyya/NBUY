namespace Proje11_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i+1}.Hello, World!");
            //}

            //int toplam = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    //toplam = toplam + i; 
            //    toplam += i;
            //}
            //Console.WriteLine($"Toplam:{toplam}");
            //int toplam=0;
            //for (int i = 0; i < =10; i=i+2)
            //{
            //    toplam += i;                
            //}
            //Console.WriteLine(toplam);

            //1-10 arasındaki çift sayıların toplamını ayrı,tek sayıların toplamını gösteren kodu ayrı yazınız
            //int cifttoplam=0;
            //int tektoplam = 0;

            //for (int i=1;i<=10;i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        toplam += i;
            //    }
            //    else
            //    {
            //        cifttoplam += i;
            //    }
            //}
            //Console.WriteLine(toplam);

            //soru:klavyeden iki sayı grilsin.bu sayılar arasındaki toplamları ekrana yazdıralım.
            //Console.Write("1.sayıyı giriniz");
            //int sayi1=Convert.ToInt32(Console.ReadLine());
            //Console.Write("2.sayıyı giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;
            //for (int i = sayi1; i <= sayi2; i++)
            //{
            //    toplam += i;
            //}
            //Console.WriteLine($"Toplam:{toplam}");

            //Console.Write("1.sayıyı giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2.sayıyı giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;
            //if (sayi2 > sayi1)
            //{
            //    for (int i = sayi1; i <= sayi2; i++)
            //    {
            //        toplam += i;
            //    }
            //}
            //else
            //{
            //    for (int i = sayi1; i >= sayi2; i--)
            //    {
            //        toplam += i;
            //    }
            //}
            //Console.WriteLine($"Toplam:{toplam}");


            //Console.Write("1.sayıyı giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2.sayıyı giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;
            //int min=Math.Min(sayi1, sayi2);
            //int max=Math.Max(sayi1, sayi2);
            //for (int i = min; i <= max; i++)
            //{
            //    toplam += i;
            //}
            //Console.WriteLine($"Toplam:{toplam}");

            //soru:program kullanıcıdan bir sayı girmesini istesin.Ancak kullanıcı sayı girmeye devam ettikçe girilen sayıların toplanmasını sağlayalım.Sayı adeti bellirsizdir. uygulamanın bitip,ekrana yazması için Exit 
            //int toplam = 0;
            //string girilenDeger = "";
            //string sonucMetin = "";
            ////string sonEk="+" 
            //for (int i = 1; i < 1000000; i++)
            //{
            //    Console.Write($"{i}.sayıyı giriniz(Çıkış için exit):");
            //    girilenDeger=Console.ReadLine();
            //    if (girilenDeger =="exit")//if küçük büyük harf duyarlı
            //    {
            //        break;//İçinde bulunan döngünün ,tamamlanmasısını beklemeden, istenilen bir anda durdurulması için kullanılır.
            //    }
            //    sonucMetin = sonucMetin + girilenDeger + " + ";
            //    //100+205
            //    toplam += Convert.ToInt32(girilenDeger);
            //}
            //int alinacakKisminUzunlugu = sonucMetin.Length - 3;
            //sonucMetin = sonucMetin.Substring(0,alinacakKisminUzunlugu);
            //Console.WriteLine($"{sonucMetin}= {toplam}");

            //Soru:5*5 lik bir kareyi biçimini * işaretiyle oluşturan uygulamayı yazınız.

            //int satir = 5;
            //int sutun = 5;
            //for (int i = 0; i < satir; i++)
            //{
            //    for (int k = 0; k < sutun; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            int satir = 5;
            int sutun = 5;
            for (int i = 1; i <= satir; i++)
            {
                for (int k = 1; k <= sutun; k++)
                {
                    if (i==1||i==satir)
                    {
                        Console.Write("*");
                    }
                   else if(k==1||k==sutun)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }//ödev:üstteki içi boş kareyi oluşturan uygulamaları adım adım çalıştırarak anlamaya çalışınız.
            //ödev1:1 ile 100 arasındaki sayıların ortalamasını bulduran program
            // ödev2:1 ile 100 arasındaki çift,tek ve 5'in katı olan sayıların adetleri vetoplamlarını ekrana yazdıran program
            //ödev3: Aşağıdaki yüksekliği 5,tabanı 9 birim olan dik üçgeni ekrana çizdiren program
            /*
             * *
             * **
             * ****
             * *****
             * *******
             */
             
        }
    }
}