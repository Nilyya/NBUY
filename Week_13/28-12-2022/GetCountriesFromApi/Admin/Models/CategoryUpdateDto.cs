using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DiariesFoodApp.Web.Admin.Models
{
    public class CategoryUpdateDto
    {
        public int Id { get; set; }

        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        [MinLength(5, ErrorMessage = "{0} , {1} karakterden kısa olmamaldır")]
        public string Name { get; set; }

        [DisplayName("Kategori Açıklaması")]
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        [MinLength(5, ErrorMessage = "{0} , {1} karakterden kısa olmamaldır")]
        public string Description { get; set; }

        [DisplayName("Kategori Url")]
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        public string Url { get; set; }
    }
}
