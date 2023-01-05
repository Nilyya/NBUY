using DiariesFoodApp.Entity.Concrete;
namespace DiariesFoodApp.Web.Models
{
    public class ProductDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Clue { get; set; }
        public string Recipe { get; set; }
        public string Preparation { get; set; }
        public string PreparationTime { get; set; }
        public string BakingTime { get; set; }
        public string Service { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public List<Category> Categories { get; set; }
    }
}
