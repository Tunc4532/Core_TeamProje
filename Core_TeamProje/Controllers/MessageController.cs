using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.Controllers
{
    public class MessageController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());

        public IActionResult Index()
        {
            ViewBag.v1 = "Mesaj Paneli";
            ViewBag.v2 = "Listeleme ";
            ViewBag.v3 = "Mesajlar";
            var values = messageManager.TGetList();
            return View(values);
        }
        public IActionResult MDetails(int id)
        {
            ViewBag.v1 = "Mesaj Paneli";
            ViewBag.v2 = "Detaylar ";
            ViewBag.v3 = "Mesaj Detaylar";


            var values = messageManager.TGetByID(id);
            return View(values);
        }

        public IActionResult MesDelete(int id)
        {
            var values = messageManager.TGetByID(id);
            messageManager.TDelete(values);
            return RedirectToAction("Index");

        }
    }
}
