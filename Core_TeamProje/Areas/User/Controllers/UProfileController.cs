using Core_TeamProje.Areas.User.Models;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.Areas.User.Controllers
{
    [Area("User")]
    [Route("User/[controller]/[action]")]
    public class UProfileController : Controller
    {

        private readonly UserManager<WriterUser> _userManager;

        public UProfileController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task <IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel model = new UserEditViewModel();
            model.Name = values.Namet;
            model.Surname = values.SurNamet;
            model.PicturUrl = values.ImageUrlt;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if(p.Pictur != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Pictur.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/UserImage/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                await p.Pictur.CopyToAsync(stream);
                user.ImageUrlt = imagename;
            }

            user.Namet = p.Name;
            user.SurNamet = p.Surname;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Pssword);
            var result = await _userManager.UpdateAsync(user);
            if(result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }

            return View();
        }
    }
}
