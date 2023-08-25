namespace Core_TeamProje.Areas.User.Models
{
    public class UserEditViewModel
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Pssword { get; set; }
        public string? PsswordConfrim { get; set; }
        public string? PicturUrl { get; set; }
        public IFormFile? Pictur { get; set; }

    }
}
