using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Profil Görğüntüle";
            ViewBag.v2 = "Profil ";
            ViewBag.v3 = "Profil Ayarları";
            return View();
        }
    }
}
