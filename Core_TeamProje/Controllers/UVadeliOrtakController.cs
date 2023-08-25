using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.Controllers
{
    public class UVadeliOrtakController : Controller
    {
        UVadeliOrtakManager tuVadeliOrtakManager = new UVadeliOrtakManager(new EfUVadeliOrtakDal());
        [HttpGet]
        public IActionResult IndexUv()
        {
            ViewBag.v1 = "Ortaklık Paneli";
            ViewBag.v2 = "Güncelleme ";
            ViewBag.v3 = "Ortaklık Güncelleme";
            var values = tuVadeliOrtakManager.TGetByID(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult IndexUv(UVadeliOrtak vadeliOrtak )
        {
            tuVadeliOrtakManager.TUpdate(vadeliOrtak);
            return RedirectToAction("Index","Default");
        }
    }
}
