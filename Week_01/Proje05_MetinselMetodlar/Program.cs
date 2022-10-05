namespace Proje05_MetinselMetodlar;
class Program
{
    static void Main(string[] args)
    {
        //Bu proje metinsel işlemlere dahil bazı metotlar öğreneceğiz
        // string metin = "Wissen Akademie";
        // int uzunluk=metin.Length;
        // Console.WriteLine($"Uzunluk:{uzunluk}");
        // Console.WriteLine($"{metin} metni {uzunluk} karakterdir.");

        // string metin = "WİSSEN";
        // string kucukMetin=metin.ToLower();
        // Console.WriteLine(kucukMetin);
        // string buyukMetin=kucukMetin.ToUpper();
        // Console.WriteLine(buyukMetin);

        // string m1 = "Wissen Akademie";
        // string m2 = "Wissen";
        // int sonuc = String.Compare(m1, m2);
        // Console.WriteLine(m1);
        // Console.WriteLine(m2);
        // Console.WriteLine(sonuc);
        /*
        Console.Write("1.Metni giriniz:");//writeline yazarsak alt satırda değeri ister write yazarsak aynı satır.
        string m1=Console.ReadLine();
        Console.Write("2.Metni giriniz:");
        string m2=Console.ReadLine();
        int sonuc=String.Compare(m1,m2);
        if (sonuc==0)
        {
            Console.WriteLine("Girilen iki metin birbirine EŞİTTİR!");
        }
        else
        {
            Console.WriteLine("Girilen iki metin birbirinden FARKLIDIR!");
        }
    string m1 = "İşKur";
    string m2 = "Eğitimleri";
    string m3 = "Wissen";
    string sonuc=m1+m2+m3
    string sonuc = String.Concat(m1, m2, m3);
     Console.WriteLine(sonuc);

    string ad = "Aylin";
    int yas = 29;
    string okul = "BAU";
       
        */
        // string metin = "Merhaba.Bu hafta eğitime başladık.";
        // bool sonuc = metin.Contains("wissen");
        // Console.WriteLine(sonuc);

        //string adres = "Selami Ali mh. Can sk. No:6 Kadıköy/İstanbul";
        // bool sonuc = adres.EndsWith("İstanbul");
        // bool sonuc2 = adres.StartsWith("İstnbul");
        // Console.WriteLine(sonuc);

        //adres içindeki c harfi kaçıncı sıradadır.
        //string aranacakifade = "c";
        //int sirano = adres.tolower().ındexof(aranacakifade.tolower());
        // console.writeline($"c harfi {adres} içinde,{sirano}.sıradadır.");

        //string metin = "Wissen Akademie";
        //Console.WriteLine($"Metnin ilk hali:{metin})";
        //Console.WriteLine($"Akademie ifadesi silindikten sonraki hali:{metin.Remove(7)}"};


        string urunAd = "IPhone 13 Pro";
        //iphone-13-pro
        //string sonuc = (urunAd.Replace(" ","-")).ToLower();
        string sonuc = urunAd.ToLower().Replace("", "-");
        Console.WriteLine(sonuc);
        string sonuc2 = urunAd.Replace("IPhone", "Samsung");
        Console.WriteLine(sonuc2);
    }
}
