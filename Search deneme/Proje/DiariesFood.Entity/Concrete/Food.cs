using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiariesFood.Entity.Concrete
{
    public class Food
    {
        public int Id { get; set; }
        public int CatId { get; set; }
        public string Name { get; set; }
        public string Clue { get; set; }
        public string Repice { get; set; }
        public string Preparation { get; set; }
        public string PreparationTime { get; set; }
        public string BakingTime { get; set; }
        public string Service { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public bool IsHome { get; set; }
        public bool IsApproved { get; set; }
        public List<FoodCategory> FoodCategories { get; set; }


    }
}