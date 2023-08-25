using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Core_TeamProje.Areas.User.Models
{


    public class UserLoginViewModel
    {
        [Display(Name ="Kullanıcı Adı")]
        [Required(ErrorMessage ="Kullanıcı Adını Girniz ")]
        public string? UserName { get; set; }
        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifrenizi Girniz ")]
        public string? Password { get; set; }

    }
}
