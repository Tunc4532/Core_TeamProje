using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.Controllers
{
    public class UzmanEkipController : Controller
    {
        UzmanEkipManager tuzmanEkipManager = new UzmanEkipManager(new EfUzmanEkipDal());

        public IActionResult Index()
        {
            ViewBag.v1 = "Hizmet Paneli";
            ViewBag.v2 = "Listeleme ";
            ViewBag.v3 = "Hizmet Listeleme";
            var values = tuzmanEkipManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddUzmanEkip()
        {
            ViewBag.v1 = "Hizmet Paneli";
            ViewBag.v2 = "Ekleme ";
            ViewBag.v3 = "Hizmet Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddUzmanEkip(UzmanEkip uzmanEkip)
        {
            tuzmanEkipManager.TAdd(uzmanEkip);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteUzmanEkip(int id)
        {
            var values = tuzmanEkipManager.TGetByID(id);
            tuzmanEkipManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditUzmanEkip(int id)
        {
            ViewBag.v1 = "Hizmet Paneli";
            ViewBag.v2 = "Güncelleme ";
            ViewBag.v3 = "Hizmet Güncelleme";
            var values = tuzmanEkipManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditUzmanEkip(UzmanEkip uzmanEkip)
        {
            tuzmanEkipManager.TUpdate(uzmanEkip);
            return RedirectToAction("Index");
        }
    }
}
