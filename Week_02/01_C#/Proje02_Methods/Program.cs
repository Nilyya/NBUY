using System.Runtime.Intrinsics.Arm;

namespace Proje02_Methods
{
    public class Program
    {
       //static void Topla(int sayi1,int sayi2)
       // {
       //     int toplam = sayi1 + sayi2;
       //     Console.WriteLine();
       //     Console.WriteLine($"Toplam:{toplam}");
       // }
       // static void Cıkarma(int sayi1,int sayi2)
       // {
       //     int cıkarma=sayi1 - sayi2;
       //     Console.WriteLine();
       //     Console.WriteLine($"Çıkartma:{cıkarma}");
       // }
       public static int Topla(int sayi1,int sayi2)
        {
            return sayi1+sayi2;
        }
        static int Cıkarma(int sayi1, int sayi2)
        {
            int fark = sayi1 - sayi2;
            return fark;
        }
        static void Main(string[] args)//METHOD
        {
            Console.Write("Birinci Sayı:");
            int s1=int.Parse(Console.ReadLine());
            Console.Write("ikinci Sayı:");
            int s2 = int.Parse(Console.ReadLine());

           int toplam= Topla(s1,s2);
           int fark= Cıkarma(s1,s2);

            Console.WriteLine($"Toplam{toplam},Fark{fark}");
            Console.WriteLine($"{toplam-fark}");

            //Kendisine verilen metnin içinde,aradığımız karakterin kaçıncı sırada olduğunu bulan program
            //Kendisine verilen metnin içinde,aradığımız karakterin OLUP OLMADIĞINI bize söyleyen bir method yazınız.
            string metin = Console.ReadLine();
            Console.WriteLine($"Bir Metin Giriniz:{metin}");
            string aranacakIfade = " ";
            int siraNo = metin.ToUpper().IndexOf(aranacakIfade.ToUpper());
            Console.WriteLine($"Boşluk {metin} içinde, {siraNo}.sıradadır.");

        }
        #region MethodOverload

       
        MethodOverload methodOverload = new MethodOverload();
        Console.WriteLine(MethodOverload.Topla(55);
        #endregion

    }
}