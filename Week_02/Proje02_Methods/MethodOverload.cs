using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje02_Methods
{
    public class MethodOverload
    {
        public void DenemeMetodu()
        {
            Console.WriteLine("Merhaba,");
        }
        public int Topla(int s1,int s2,int s3=0)
        { 
            return s1 + s2+s3;
        }
    }
}
