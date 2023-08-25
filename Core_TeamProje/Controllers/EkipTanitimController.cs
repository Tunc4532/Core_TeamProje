using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.Controllers
{
    public class EkipTanitimController : Controller
    {
        EkipTanitimManager tekipTanitimManager = new EkipTanitimManager(new EfEkipTanitimDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Takım Paneli";
            ViewBag.v2 = "Listeleme ";
            ViewBag.v3 = "Takım Listeleme";
            var values = tekipTanitimManager.TGetList();
            return View(values);
        }


        [HttpGet]
        public IActionResult AddEkipTanitim()
        {
            ViewBag.v1 = "Takım Paneli";
            ViewBag.v2 = "Ekleme ";
            ViewBag.v3 = "Takım Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddEkipTanitim(EkipTanitim ekipTanitim)
        {
            tekipTanitimManager.TAdd(ekipTanitim);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteEkipTanitim(int id)
        {
            var values = tekipTanitimManager.TGetByID(id);
            tekipTanitimManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditEkipTanitim(int id)
        {
            ViewBag.v1 = "Takım Paneli";
            ViewBag.v2 = "Güncelleme ";
            ViewBag.v3 = "Takım Güncelleme";
            var values = tekipTanitimManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditEkipTanitim(EkipTanitim ekipTanitim)
        {
            tekipTanitimManager.TUpdate(ekipTanitim);
            return RedirectToAction("Index");
        }
    }
}
