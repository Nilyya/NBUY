using ShoppingApp.Entity.Concrete;
namespace ShoppingApp.Web.Areas.Admin.Models.Dtos
{
    public class ProductListDto
    {
        public Product Products { get; set; }
        public List<Category> Categories { get; set; }
        public Product Product { get; internal set; }
    }
}
