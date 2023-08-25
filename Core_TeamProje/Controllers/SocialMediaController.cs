using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.Controllers
{
    public class SocialMediaController : Controller
    {
        EkipTanitimManager socialTanitimManager = new EkipTanitimManager(new EfEkipTanitimDal());
        public IActionResult SocialeList()
        {
            ViewBag.v1 = "Sosyal Medya";
            ViewBag.v2 = "Listeleme ";
            ViewBag.v3 = "Güncelle";
            var values = socialTanitimManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddESocialMedıa()
        {
            ViewBag.v1 = "Sosyal Medya";
            ViewBag.v2 = "Ekleme ";
            ViewBag.v3 = "Listeleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddESocialMedıa(EkipTanitim ekipTanitim)
        {
            socialTanitimManager.TAdd(ekipTanitim);
            return RedirectToAction("SocialeList");
        }
        public IActionResult DeleteESocialMedıa(int id)
        {
            var values = socialTanitimManager.TGetByID(id);
            socialTanitimManager.TDelete(values);
            return RedirectToAction("SocialeList");
        }
        [HttpGet]
        public IActionResult EditESocialMedıa(int id)
        {
            ViewBag.v1 = "Sosyal Medya";
            ViewBag.v2 = "Güncelleme ";
            ViewBag.v3 = "Listeleme";
            var values = socialTanitimManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditESocialMedıa(EkipTanitim ekipTanitim)
        {
            socialTanitimManager.TUpdate(ekipTanitim);
            return RedirectToAction("SocialeList");
        }
    }
}
