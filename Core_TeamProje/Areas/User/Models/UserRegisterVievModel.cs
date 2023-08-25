using System.ComponentModel.DataAnnotations;

namespace Core_TeamProje.Areas.User.Models
{
    public class UserRegisterVievModel
    {
        [Required(ErrorMessage = "Lütfen Adınızı Girin")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Lütfen Soyadınızı Girin")]
        public string? SurName { get; set; }
        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Girin")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "Lütfen Resim url Girin")]
        public string? ImageUrl { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi Girin")]
        public string? Password { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi Tekrar Girin")]
        [Compare("Password",ErrorMessage ="Şifreler Uyumlu Değil!!!")]
        public string? ConfimPassword { get; set; }
        [Required(ErrorMessage = "Lütfen Mailinizi Girin")]
        public string? Mail { get; set; }
    }
}
