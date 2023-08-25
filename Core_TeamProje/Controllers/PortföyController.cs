using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.Controllers
{
    public class PortföyController : Controller
    {
        PortföyManager tportföyManager = new PortföyManager(new EfPortföyDal());

        public IActionResult Index()
        {
            ViewBag.v1 = "Proje Paneli";
            ViewBag.v2 = "Listeleme ";
            ViewBag.v3 = "Proje Listeleme";
            var values = tportföyManager.TGetList();
            return View(values);
        }


        [HttpGet]
        public IActionResult AddPortföy()
        {
            ViewBag.v1 = "Proje Paneli";
            ViewBag.v2 = "Ekleme ";
            ViewBag.v3 = "Proje Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddPortföy(Portföy portföy)
        {
            tportföyManager.TAdd(portföy);
            return RedirectToAction("Index");
        }
        public IActionResult DeletePortföy(int id)
        {
            var values = tportföyManager.TGetByID(id);
            tportföyManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditPortföy(int id)
        {
            ViewBag.v1 = "Proje Paneli";
            ViewBag.v2 = "Güncelleme ";
            ViewBag.v3 = "Proje Güncelleme";
            var values = tportföyManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditPortföy(Portföy portföy)
        {
            tportföyManager.TUpdate(portföy);
            return RedirectToAction("Index");
        }
    }
}
