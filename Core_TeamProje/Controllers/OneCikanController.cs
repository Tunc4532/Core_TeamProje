using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.Controllers
{
    public class OneCikanController : Controller
    {
        OneCikanManager oneCikanManager = new OneCikanManager(new EfOneCikanDal());
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "Öne Çıkan Paneli";
            ViewBag.v2 = "Güncelleme ";
            ViewBag.v3 = "Öne Çıkan Güncelleme";
            var values = oneCikanManager.TGetByID(1);
            return View(values);
        }
         
        [HttpPost]
        public IActionResult Index(OneCikan oneCikan)
        {
            oneCikanManager.TUpdate(oneCikan);
            return RedirectToAction("Index","Default");
        }
    }
}

