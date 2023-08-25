using Core_TeamProje.Areas.User.Models;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.Areas.User.Controllers
{
    [Area("User")]
    [Route("User/[controller]/[action]")]
    public class RegeisterController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public RegeisterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Index(UserRegisterVievModel p)
        {
            if(ModelState.IsValid )
            {
                WriterUser w = new WriterUser()
                {
                    Namet = p.Name,
                    SurNamet = p.SurName,
                    Email = p.Mail,
                    UserName = p.UserName,
                    ImageUrlt = p.ImageUrl
                };

                if (p.ConfimPassword == p.Password)
                {
                    var result = await _userManager.CreateAsync(w, p.Password);


                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Login");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }

                    }
                }
            }
            return View(p);
        }
    }
}
