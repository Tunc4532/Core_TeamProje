using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.Controllers
{
    public class CevikEkipControlle : Controller
    {
        CevikEkipManager tcevikEkipManager = new CevikEkipManager(new EfCevikEkipDal());

        public IActionResult Index()
        {
            ViewBag.v1 = "Hizmet Paneli";
            ViewBag.v2 = "Listeleme ";
            ViewBag.v3 = "Hizmet Listeleme";
            var  values =  tcevikEkipManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCevikEkip()
        {
            ViewBag.v1 = "Hizmet Paneli";
            ViewBag.v2 = "Ekleme ";
            ViewBag.v3 = "Hizmet Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddCevikEkip(CevikEkip cevikEkip)
        {
            tcevikEkipManager.TAdd(cevikEkip);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteCevikEkip(int id)
        {
            var values = tcevikEkipManager.TGetByID(id);
            tcevikEkipManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditCevikEkip(int id)
        {
            ViewBag.v1 = "Hizmet Paneli";
            ViewBag.v2 = "Güncelleme ";
            ViewBag.v3 = "Hizmet Güncelleme";
            var values = tcevikEkipManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditCevikEkip(CevikEkip cevikEkip)
        {
            tcevikEkipManager.TUpdate(cevikEkip);
            return RedirectToAction("Index");
        }
    }
}
