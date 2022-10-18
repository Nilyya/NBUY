namespace Proje06_MatematikselMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi1 = 43;
            //int sayi2 = 55;
            //int minimum=Math.Min(sayi1, sayi2);
            //int maximum=Math.Max(sayi1, sayi2);
            //Console.WriteLine($"minimum: {minimum}\nMaksimum: {maximum}");

            //int taban = 4;
            //int us = 2;
            //double sonuc=Math.Pow(taban, us);
            //Console.WriteLine(sonuc);

            //Console.Write("Taban:");
            //int taban = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Üs:");
            //int us=int.Parse(Console.ReadLine());
            //double sonuc=Math.Pow(taban,us);
            //Console.WriteLine($"Sonuç:{sonuc}");

            double sayi = 5.493486;
            Console.WriteLine(Math.Ceiling(sayi));//üste yuvarlar
            Console.WriteLine(Math.Floor(sayi));//alta yuvarlar
            Console.WriteLine(Math.Round(sayi,2));//virgülden sonra 2 basamak


        }
    }
}