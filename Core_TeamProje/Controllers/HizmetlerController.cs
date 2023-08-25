using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.Controllers
{
    public class HizmetlerController : Controller
    {
        HizmetlerManager thizmetlerManager = new HizmetlerManager(new EfHizmetlerDal());

        public IActionResult Index()
        {
            ViewBag.v1 = "Hizmet Paneli";
            ViewBag.v2 = "Listeleme ";
            ViewBag.v3 = "Hizmet Listeleme";
            var values = thizmetlerManager.TGetList();
            return View(values);
        }


        [HttpGet]
        public IActionResult AddHizmetler()
        {
            ViewBag.v1 = "Hizmet Paneli";
            ViewBag.v2 = "Ekleme ";
            ViewBag.v3 = "Hizmet Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddHizmetler(Hizmetler hizmetler)
        {
            thizmetlerManager.TAdd(hizmetler);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteHizmetler(int id)
        {
            var values = thizmetlerManager.TGetByID(id);
            thizmetlerManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditHizmetler(int id)
        {
            ViewBag.v1 = "Hizmet Paneli";
            ViewBag.v2 = "Güncelleme ";
            ViewBag.v3 = "Hizmet Güncelleme";
            var values = thizmetlerManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditHizmetler(Hizmetler hizmetler)
        {
            thizmetlerManager.TUpdate(hizmetler);
            return RedirectToAction("Index");
        }
    }
}
