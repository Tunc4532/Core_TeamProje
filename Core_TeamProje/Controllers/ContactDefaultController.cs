using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.Controllers
{
    public class ContactDefaultController : Controller
    {
        ContactManager econtactManager = new ContactManager(new EfContactDal());
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "İletişim Paneli";
            ViewBag.v2 = "Güncelleme ";
            ViewBag.v3 = "İletişim Metin Güncelleme";
            var values = econtactManager.TGetByID(1);
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            econtactManager.TUpdate(contact);
            return RedirectToAction("Index", "Default");
        }
    }
}
