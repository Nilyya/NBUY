using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using DiariesFood.Entity.Concrete;

namespace DiariesFood.Web.Admin.Models.Dtos
{
    public class FoodAddDto
    {
        public int Id { get; set; }

        [DisplayName("Yemek Adı")]
        [Required(ErrorMessage = "{0} boş bırakılamaz")]
        [MinLength(5, ErrorMessage = "{0} , {1} karakterden kısa olamaz")]
        public string Name { get; set; }


        [DisplayName("Açıklama")]
        [Required(ErrorMessage = "{0} boş bırakılamaz")]
        [MinLength(5, ErrorMessage = "{0} , {1} karakterden kısa olamaz")]
        public string Clue{ get; set; }

        [DisplayName("Tarif")]
        [Required(ErrorMessage = "{0} boş bırakılamaz")]
        [MinLength(5, ErrorMessage = "{0} , {1} karakterden kısa olamaz")]
        public string Repice { get; set; }

        [DisplayName("Hazırlanışı")]
        [Required(ErrorMessage = "{0} boş bırakılamaz")]
        [MinLength(5, ErrorMessage = "{0} , {1} karakterden kısa olamaz")]
        public string Preparation { get; set; }


        [DisplayName("Hazırlanış Süresi")]
        [Required(ErrorMessage = "{0} boş bırakılamaz")]
        [MinLength(5, ErrorMessage = "{0} , {1} karakterden kısa olamaz")]
        public string PrepationTime { get; set; }


        [DisplayName("Kaç Kişilik")]
        [Required(ErrorMessage = "{0} boş bırakılamaz")]
        [MinLength(5, ErrorMessage = "{0} , {1} karakterden kısa olamaz")]
        public string Service { get; set; }

        [DisplayName("Yemek Resmi")]
        [Required(ErrorMessage = "{0}  seçilmelidir")]
        public IFormFile ImageFile { get; set; }


        [DisplayName("Anasayfa yemeği mi?")]
        public bool IsHome { get; set; }


        [DisplayName("Onaylı Yemek mi?")]
        public bool IsApproved { get; set; }

        [DisplayName("Yemek Kategorileri")]
        public List<Category> Categories { get; set; }

        [DisplayName("Hazırlanma ve Pişirme Süresi")]
        public string BakingTime { get; set; }

        [Required(ErrorMessage = "En az bir kategori seçmelisiniz")]
        public int[] SelectedCategoryIds { get; set; }
        public string ImageUrl { get; set; }
    }
}
