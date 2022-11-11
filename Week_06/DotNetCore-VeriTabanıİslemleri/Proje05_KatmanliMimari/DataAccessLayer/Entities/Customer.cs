using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje05_KatmanliMimari.DataAccessLayer.Entities
{
    public class Customer
    {
        public int CustomerID {get; set;}
        public string CompanyName {get; set;}
        public string City {get; set;}
        public string Country {get; set;}  
    }
}