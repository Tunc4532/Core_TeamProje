using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.Controllers
{
    public class BizimleCalisinController : Controller
    {
        BizimleCalisinManager tbizimleCalisinManager = new BizimleCalisinManager(new EfBizimleCalisinDal());

        public IActionResult Index()
        {
            ViewBag.v1 = "Hizmet Paneli";
            ViewBag.v2 = "Listeleme ";
            ViewBag.v3 = "Hizmet Listeleme";
            var values = tbizimleCalisinManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddBizimleCalisin()
        {
            ViewBag.v1 = "Hizmet Paneli";
            ViewBag.v2 = "Ekleme ";
            ViewBag.v3 = "Hizmet Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddBizimleCalisin(BizimleCalisin bizimleCalisin)
        {
            tbizimleCalisinManager.TAdd(bizimleCalisin);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteBizimleCalisin(int id)
        {
            var values = tbizimleCalisinManager.TGetByID(id);
            tbizimleCalisinManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditBizimleCalisin(int id)
        {
            ViewBag.v1 = "Hizmet Paneli";
            ViewBag.v2 = "Güncelleme ";
            ViewBag.v3 = "Hizmet Güncelleme";
            var values = tbizimleCalisinManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditBizimleCalisin(BizimleCalisin bizimleCalisin)
        {
            tbizimleCalisinManager.TUpdate(bizimleCalisin);
            return RedirectToAction("Index");
        }
    }
}
