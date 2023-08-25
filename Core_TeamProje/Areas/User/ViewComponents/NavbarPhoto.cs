using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.Areas.User.ViewComponents
{
    public class NavbarPhoto : ViewComponent
    {
        private readonly UserManager<WriterUser> _userManager;

        public NavbarPhoto(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task <IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.r1 = values.ImageUrlt;
            return View(values);
        }

    }
}
