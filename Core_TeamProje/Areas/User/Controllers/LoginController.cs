using Core_TeamProje.Areas.User.Models;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.Areas.User.Controllers
{
    [Area("User")]
    [Route("User/[controller]/[action]")]
    public class LoginController : Controller
    {
        private readonly SignInManager<WriterUser> _signInManager;

        public LoginController(SignInManager<WriterUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserLoginViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.UserName, p.Password,true,true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "UProfile");
                }
                else
                {
                    ModelState.AddModelError("", "Hatalı Kulanıcı Adı veya Şifre");
                }
            }
            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Login");

        }

    }
}
