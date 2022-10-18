namespace Proje08_Hatakontrolu
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                //buraya normalde çalışmasını istediğimiz kodları yazıyoruz
                //try bloğunda herhangi bir Hata var mı yok mu kontrol ediliyor
                //Eğer bir hata oluşursa,CATCh bloğuna yönlendiriliyor
                Console.Write("1.Sayıyı giriniz:");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2.Sayıyı giriniz:");
                int sayi2 = Convert.ToInt32(Console.ReadLine());
                int sonuc = Convert.ToByte(sayi1 / sayi2);
                Console.WriteLine(sonuc);
            }
			catch (DivideByZeroException ex)
			{

                Console.WriteLine("Sıfıra bölünme hatası var!");
                //Console.WriteLine(ex.Message);
			}
            catch(IndexOutOfRangeException ex)
            {
            
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Haddinden fazla büyük bir sayı girdiniz!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Bilinmeyen bir hata oluştu!");
            }
            finally
            {
                //try yada catch hangi blok çalışırsa çalısın, her halükarda çalışmasını istediğimiz kodları buraya yazın.
                Console.WriteLine("Program sona ermiştir!");
            }
        }
    }
}