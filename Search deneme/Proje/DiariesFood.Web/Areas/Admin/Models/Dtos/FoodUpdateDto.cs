using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using DiariesFood.Entity.Concrete;

namespace DiariesFood.Web.Admin.Models.Dtos
{
    public class FoodUpdateDto
    {
        public int Id { get; set; }

        [DisplayName("Yemek Adı")]
        [Required(ErrorMessage = "{0} boş bırakılamaz")]
        [MinLength(5, ErrorMessage = "{0} , {1} karakterden kısa olamaz")]

        public string Name { get; set; }
        [DisplayName("Kaç Kişilik")]
        public string Service { get; set; }

        [DisplayName("Malzemeler")]
        [Required(ErrorMessage = "{0} boş bırakılamaz")]
        [MinLength(5, ErrorMessage = "{0} , {1} karakterden kısa olamaz")]

        public string Repice { get; set; }

        [DisplayName("Hazırlanış")]
        [Required(ErrorMessage = "{0} boş bırakılamaz")]
        [MinLength(5, ErrorMessage = "{0} , {1} karakterden kısa olamaz")]

        public string Preparation { get; set; }

        [DisplayName("Yemek Resmi")]
        public IFormFile ImageFile { get; set; }

        [DisplayName("Anasayfa yemeği mi?")]
        public bool IsHome { get; set; }
        [DisplayName("Onaylı Yemek mi?")]
        public bool IsApproved { get; set; }

        [DisplayName("Yemek Kategorileri")]
        public List<Category> Categories { get; set; }
        [DisplayName("Hazırlama Süresi")]
        public string PreparationTime { get; set; }
        [DisplayName("Pişirme Süresi")]
        public string BakingTime { get; set; }

        [Required(ErrorMessage = "En az bir kategori seçmelisiniz")]
        public int[] SelectedCategoryIds { get; set; }

        public string ImageUrl { get; set; }
        public string Url { get; set; }
    }
}
