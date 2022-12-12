using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Core
{
    public static class Jobs
    {
        public static string InitUrl(string url)
        {
            //Bu method kendisine gelen url değişkeninin içindeki
            //1 türkçe karakterler yerine latin alfabesindeki harfleri yazacak
            //2 latin alfabesine çevrilirke I-i ı,i
            //3 Boşluklar - olacak
            //4 . / işaretleri kaldırılacak
            #region Sorunlu karakterler
            url = url.Replace("I", "i");
            url = url.Replace("İ", "i");
            url = url.Replace("ı", "i");
            #endregion

            #region Küçük harf
            url = url.ToLower();

            #endregion

            #region Türkçe karakterler değiştiriliyor
            url = url.Replace("ö", "o");
            url = url.Replace("ü", "u");
            url = url.Replace("ş", "s");
            url = url.Replace("ç", "c");
            url = url.Replace("ğ", "g");
            #endregion

            #region Boşluklar Tire ile değiştriliyor
            url = url.Replace(" ", "-");
            #endregion
            #region MyRegion
            url = url.Replace(".", "");
            url = url.Replace("/", "");
            url = url.Replace("\"", "");
            url = url.Replace("'", "");
            url = url.Replace("(", "");
            url = url.Replace(")", "");
            url = url.Replace("[", "");
            url = url.Replace("]", "");
            url = url.Replace("{", "");
            url = url.Replace("}", "");
            #endregion



            return (url);

        }

   
    }
}
