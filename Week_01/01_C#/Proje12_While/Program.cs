namespace Proje12_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int sayac=1;
            // while (sayac<=5)
            // {
            //    Console.WriteLine("Hello, World!");  
            //    sayac++;
            // }
// int toplam=0;
// string girilenDeger="";
// int sayac=1;

// while (girilenDeger!="exit")
// {
//     System.Console.WriteLine($"{sayac}.sayıyı giriniz(Çıkış için exit):");
//     girilenDeger=Console.ReadLine();
    // if(girilenDeger!="exit")toplam+=Convert.ToInt32(girilenDeger);
//     try
//     {
//      toplam+=Convert.ToInt32(girilenDeger);   
//     }
//     catch (System.Exception)
//     {
//         break;
//     }
//     sayac++;
// }
//         Console.WriteLine(toplam);   
//soru klavyeden exit yazılana kadar isim girilmesini isteyen program
//Çözüm_1:
// string isim="";
// while (isim!="exit")
// {
//     Console.Write("isim giriniz:");
//     isim=Console.ReadLine();
// }
// System.Console.WriteLine("Program sona erdi...");
//Çözüm_2:
// string isim;
// do
// {
//     System.Console.WriteLine("isim giriniz:");
//     isim=Console.ReadLine();
// } while (false);
// Console.WriteLine("Program sona erdi...");

//klavyeden exit yazılana kadar sayı almaya devam edn exit yazılınca sayıları ekrana yazan program
// string girilenDeger;
// int sayac=1;
// int toplam;
// do
// {
// System.Console.WriteLine($"{sayac}.sayı giriniz:");
// girilenDeger=Console.ReadLine();
// if(girilenDeger!="exit")toplam+=Convert.ToInt32(girilenDeger);
// } while (girilenDeger!="exit");



// Random rastgele=new Random();
// int rasgeleSayi=rastgele.Next();
// System.Console.WriteLine(rasgeleSayi);
// int rastgeleSayi2=rastgele.Next(100);
// System.Console.WriteLine(rastgeleSayi2);
// int rastgeleSayi3=rastgele.Next(1000,2000);
// System.Console.WriteLine(rastgeleSayi3);


//OYUN: uygulamanın rastgele üreteceği bir sayının kullanıcın tahmin etmesini isteyeceğiz
//rastgele üretilecek olan sayı 1-11 arasında olsun.
//kullanıcı rastgele sayıdan küçük yada büyük bir sayı girildiğinde kullanıcıya uygun bir mesaj verilsin.
// Doğru sayıyı tahmin edene kadar uygulama çalışın(X)
//Kullanıcı doğru sayıyı tahmin ettiyse yada 3 hakkını kullandıysa uygulama sona ersin!

// Random rnd=new Random();
// int uretilenSayi=rnd.Next(1,101);
// System.Console.WriteLine($"Hile:{uretilenSayi}");
// System.Console.WriteLine("*****");
// int tahminEdilenSayi;
// int hak=1;//Kullanıcının o sırada kaçıncı hakkını kullandığı bilgisi
// int hakSiniri=5;//Kullanıcın toplam kaç hakka sahip olduğu bilgisi
// do
// {
//     System.Console.WriteLine($"{hak}.Tahmininizi giriniz(1-100):");
//     tahminEdilenSayi=Convert.ToInt32((Console.ReadLine()));
//     if (hak==hakSiniri && uretilenSayi!=tahminEdilenSayi)
//     {
//         System.Console.WriteLine("Kaybettiniz");
//         break;
//     }
//     if (tahminEdilenSayi>uretilenSayi)
//     {
//         System.Console.WriteLine("Büyük bir değer girdiniz, daha küçük bir değer girerek yeniden deneyiniz! ");
//     }
//     else if(tahminEdilenSayi<uretilenSayi)
//     {
//        System.Console.WriteLine("Küçük bir değer girdiniz, daha büyük bir değer girerek yeniden deneyiniz!"); 
//     }
//     else
//     {
//         System.Console.WriteLine("Tebrikler bildiniz!");
//     }
//     hak++;
// } while (tahminEdilenSayi!=uretilenSayi&&hak<=hakSiniri);
    //  do
    //  {
        
    //  } while (tahminEdilenSayi!=uretilenSayi&&hak<=hakSiniri);
     //Eğer program bu satıla gelmiş ise ya doğru tahminde bulunulmuştur yada hak sona ermiştir.
    //  System.Console.WriteLine($"{hak}.Tahmininizi giriniz(1-100):");
    // tahminEdilenSayi=Convert.ToInt32((Console.ReadLine()));
    // if (tahmin)
    // {
        
    // }

    

        }
    }
}