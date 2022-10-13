namespace Proje03_Sayi_Bulmaca_With_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Random rnd = new Random();
            int uretilenSayi = rnd.Next(1, 101);
           Console.WriteLine($"hile:{uretilenSayi}");
           Console.WriteLine("*****");
            int tahminEdilenSayi;
            int hak = 1;
            int hakSiniri = 5;
            string mesaj = "";

            do
            {
                Console.Write($"{hak}.Tahmininizi giriniz(1-100): ");
                tahminEdilenSayi = Convert.ToInt32(Console.ReadLine());
                if (tahminEdilenSayi > uretilenSayi)
                {
                    Console.WriteLine("Büyük girdin");
                    mesaj = "Büyük girdin";
                }
                else if (tahminEdilenSayi < uretilenSayi)
                {
                    Console.WriteLine("Küçük girdin");
                    mesaj = "Küçük girdin";
                }
                if (tahminEdilenSayi != uretilenSayi)
                {
                    hak++;
                    if (hak <= hakSiniri)
                    {
                        Console.WriteLine("Kaybettin!");
                    }
                }
                else
                {
                    Console.WriteLine("Kazandın!");
                    if (hak <= hakSiniri) Console.WriteLine(mesaj);
                }

            } while (tahminEdilenSayi != uretilenSayi && hak <= hakSiniri);

            mesaj = tahminEdilenSayi == uretilenSayi ? "Kazandınız" : "Kaybettiniz";
            Console.WriteLine(mesaj);
        }
    }
}