using ShoppingApp.Entity.Concrete;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ShoppingApp.Web.Areas.Admin.Models.Dtos { 
    public class ProductUpdateDto
    {
    public int Id { get; set; }
    [DisplayName("Ürün Adı")]
    [Required(ErrorMessage = "{0} boş bırakılmamalıdır.")]
    [MinLength(5, ErrorMessage = "{0}, {1} karakterden kısa olmalıdır.")]
    [MaxLength(50, ErrorMessage = "{0}, {1} karakterden uzun olmalıdır.")]
    public string Name { get; set; }
    [DisplayName("Fiyat")]
    [Required(ErrorMessage = "{0} boş bırakılmamalıdır.")]
    public decimal? Price { get; set; }
    [DisplayName("Açıklama")]
    [Required(ErrorMessage = "{0} boş bırakılmamalıdır.")]
    [MinLength(5, ErrorMessage = "{0}, {1} karakterden kısa olmalıdır.")]
    [MaxLength(500, ErrorMessage = "{0}, {1} karakterden uzun olmalıdır.")]
    public string Description { get; set; }
    [DisplayName("Kategori Adı")]
    [Required(ErrorMessage = "{0} ürün resmi seçilmelidir.")]
    public IFormFile ImageFile { get; set; }
    [DisplayName("AnaSayfa")]
    public bool Ishome { get; set; }
    [DisplayName("Onaylı ürün")]
    public bool IsApproved { get; set; }
    [DisplayName("Kategoriler")]
    public List<Category> Categories { get; set; }
    [Required(ErrorMessage = "En az bir kategori seçilmelidir.")]
    public List<Category> SelectedCategories { get; set; }
        public int Id { get; internal set; }
    }
}
