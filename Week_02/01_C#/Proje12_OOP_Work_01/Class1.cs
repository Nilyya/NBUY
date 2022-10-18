using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje11_Collections_GenericList
{
    public class Bolum
    {
        public int BolumId { get; set; }
        public string BolumAdı { get; set; }
        public string Acıklama { get; set; }
    }


    public class Ogrenci:Bolum
    {
        public int Id { get; set; }
        public int OgrenciNo { get; set; }
        public string OgrenciAdı { get; set; }
        public string OgrenciSoyad { get; set; }
        public int Yas { get; set; }

    }
}
