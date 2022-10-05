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
            int cifttoplam=0;
            int tektoplam = 0;

            for (int i=1;i<=10;i++)
            {
                if (i % 2 == 0)
                {
                    toplam += i;
                }
                else
                {
                    cifttoplam += i;
                }
            }
            Console.WriteLine(toplam);
        }
    }
}