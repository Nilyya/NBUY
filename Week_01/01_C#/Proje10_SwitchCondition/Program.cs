namespace Proje10_SwitchCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen bir sayının 5 olması halinde 2 katını, 10 olması halinde 3 katını yada 15 olması halinde ise 4 katını ekrana yazan programı hazırlayalım.Eğer üçü de değilse Tanımlanamayan değer yazsın.
            //Console.WriteLine("Lütfen bir sayı giriniz(5-10-15):")
            // int sayi = Convert.ToInt32(Console.ReadLine());
            // int sonuc = 0;
            // switch(sayi)
            // {
            //     case 5:
            //         sonuc = sayi * 2;
            //         break;
            //     case 10:
            //         sonuc=sayi * 3;
            //         break;
            //     case 15:
            //         sonuc=sayi * 4;
            //         break;
            //     default:
            //         sonuc = 0;
            //         break;
            // }
            // if
            //     {
            //     Console.WriteLine("TANIMLANMAMIŞ DEĞER!");
            // }
            // else
            // {
            //     Console.WriteLine(sonuc);
            // }
            // //if (sayi==5)
            // //{
            // //    sonuc=sayi*2;
            // //}
            // //else if(sayi==10)
            // //{
            // //    sonuc=sayi*3;
            // //}
            // //else if(sayi==15)
            // //{
            // //    sonuc =sayi*4;
            // //}
            // //if (sonuc==0)
            // //{
            // //    Console.WriteLine("Tanımlanmamış değer!");
            // //}



            //x->5-10-> 2 ile çarpsın
            //x->11-20-> 3 ile çarpsın
            //x->21-50-> 4 ile çarpsın
            //x->51-100-> 5 ile çarpsın
            //x->100-> 10 ile çarpsın
            ////çözüm1:if
            //int x = 11;
            //int sonuc = 0;
            //int katsayi = 0;
            //if(x<=10)
            //{
            //    katsayi =2;
            //}
            //else if(x<=20)
            //{
            //    katsayi = 3;
            //}
            //else if(x<=50)
            //{
            //    katsayi=4;
            //}
            //else if(x<=100)
            //{
            //    katsayi =5;
            //}
            //else
            //{
            //    katsayi=10
            //}
            //int sonuc = x + katsayi;
            //Console.WriteLine($"x={x},sonuç:{sonuc}");//x:25,Sonuç:100
            //Console.WriteLine($"x:{x}x katsayı{katsayi}:{sonuc});
            //x:25, sonuç:25*


            //int x = 120;
            //int katsayı = 0;
            //switch(x)
            //{
            //    case (>= 0 and <= 10):
            //        katsayi = 2;
            //        break;
            //    case (>= 11 and <= 20):
            //        katsayi = 3;
            //        break;

            //}
            //int sonuc = x * katsayı;
            //Console.WriteLine($"x:{x},sonuc{x}*{katsayı}:{sonuc}");

            //gün haftaiçi mi haftasonu mu

            //switch(gun)
            //{

            //        case DayOfWeek.Monday:
            //        case DayOfWeek.Tuesday:
            //        case DayOfWeek.Wednesday:
            //        case DayOfWeek.Thursday:
            //        case DayOfWeek.Friday:
            //        Console.WriteLine("hafta içi");
            //        break;
            //        case DayOfWeek.Saturday:
            //        case DayOfWeek.Sunday:
            //        Console.WriteLine("hafta sonu")
            //            break;
            //    default:
            //        break;
            switch (gun)
            {

                case DayOfWeek.Monday or
                 DayOfWeek.Tuesday or
                 DayOfWeek.Wednesday or
                 DayOfWeek.Thursday or
                 DayOfWeek.Friday:
                    Console.WriteLine("hafta içindesin,üzgünüm,çalışmalısın");
                    break;
                case DayOfWeek.Saturday or
                 DayOfWeek.Sunday:
                    Console.WriteLine("hafta sonu")
                        break;
                default:
                    break;
            }
        }
    }
}