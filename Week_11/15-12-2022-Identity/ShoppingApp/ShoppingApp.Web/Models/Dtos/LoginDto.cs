using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace ShoppingApp.Web.Models.Dtos
{
    public class LoginDto
    {
        [DisplayName("Kullanıcı Adı")]
        [Required(ErrorMessage ="{0} boş bırakılmamalıdır.")]
        public string UserName { get; set; }
        [DisplayName("Şifre")]
        [Required(ErrorMessage = "{0} boş bırakılmamalıdır.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }

    }
}
