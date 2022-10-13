using Proje12_OPP_Work01_Ders;

namespace Proje12_OPP_Work01_Ders
{
    interface IBase
    {
        static string GirisYap(string baslik)
        {
            Console.Write(baslik);
            return Console.ReadLine();
        }
        public int Id { get; set; }
        public string Ad { get; set; }
    }
    class Bolum : IBase
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Acıklama { get; set; }
        public List<Ogrenci> ogrenciler { get; set; }
    }
    class Ogrenci:IBase
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int OgrNo { get; set; }
        public string SoyAd { get; set; }
        public int Yas { get; set; }
    }
    {
        static void Main (string[] args)
        {
        List<Bolum> bolumler = new List<Bolum>();
        for (int i = 0; i < 2; i++)
        {
            Bolum bolum = new Bolum();
            bolum.Id = int.Parse();
           
            for (int j = 0; j < 3; j++)
            {
                Ogrenci ogrenci = new Ogrenci();
                Console.WriteLine($"{i + j}Öğrenci Id:");
                ogrenci.Id = int.Parse(Console.ReadLine());
                Console.WriteLine($"{j + 1}Öğrenci Adı");
ogrenci.Ad = Console.ReadLine();


                
            }

        }
        }
    }
}
// Bolum bolum = new Bolum();
//Console.WriteLine($"{i + 1}.Bölüm Id:");
//bolum.Id = int.Parse(Console.ReadLine());
//Console.WriteLine($"{i + 1}.Bölüm Adı:");
//bolum.Ad = (Console.ReadLine());
//Console.WriteLine($"{i + 1}.Bölüm Açıklama:");
//bolum.Acıklama = (Console.ReadLine());