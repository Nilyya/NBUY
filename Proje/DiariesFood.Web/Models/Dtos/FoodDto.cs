using DiariesFood.Entity.Concrete;

namespace DiariesFood.Web.Models.Dtos
{
    public class FoodDto
    {
        public int Id { get; set; }
        public int? CatId { get; set; }
        public string Name { get; set; }
        public string Clue { get; set; }
        public string Repice { get; set; }
        public string Preparation { get; set; }
        public string PreparationTime { get; set; }
        public string BakingTime { get; set; }
        public string Service { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public List<Category> Categories { get; set; }
    }
}
