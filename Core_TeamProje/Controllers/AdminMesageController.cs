using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.Controllers
{
    public class AdminMesageController : Controller
    {
        WriterMessageManager writerMessage = new WriterMessageManager(new EfWriterMessageDal());

        public IActionResult ReciveMessageLis()
        {
            ViewBag.v1 = "Admin Mesaj Paneli";
            ViewBag.v2 = " Gelen Mesaj Listeleme ";
            ViewBag.v3 = " Admin Mesajlar";
            string p;
            p = "admin@gmail.com";
            var values = writerMessage.GetListAliciMessage(p);
            return View(values);
        }

        public IActionResult SendMessageLis()
        {
            ViewBag.v1 = "Admin Mesaj Paneli";
            ViewBag.v2 = " Giden Mesaj Listeleme ";
            ViewBag.v3 = " Admin Mesajlar";
            string p;
            p = "admin@gmail.com";
            var values = writerMessage.GetListGonderenMessage(p);
            return View(values);
        }

        public IActionResult AdminDetails(int id)
        {
            ViewBag.v1 = "Mesaj Paneli";
            ViewBag.v2 = "Detaylar ";
            ViewBag.v3 = "Mesaj Detaylar";
            var values = writerMessage.TGetByID(id);
            return View(values);
        }

        public IActionResult AdminDelete(int id)
        {
            var values = writerMessage.TGetByID(id);
            writerMessage.TDelete(values);
            return RedirectToAction("SendMessageLis");

        }

        [HttpGet]
        public IActionResult AddAMessage()
        {
            ViewBag.v1 = "Hizmet Paneli";
            ViewBag.v2 = "Ekleme ";
            ViewBag.v3 = "Hizmet Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddAMessage(WriterMessage eMessage)
        {
            eMessage.Gonderen = "admin@gmail.com";
            eMessage.Gonderenadi = "admin";
            eMessage.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            Context c = new Context();
            var usernamesurmane = c.Users.Where(x => x.Email == eMessage.Alici).Select(y => y.Namet + " " + y.SurNamet).FirstOrDefault();
            eMessage.Aliciadi = usernamesurmane;
            writerMessage.TAdd(eMessage);
            return RedirectToAction("SendMessageLis");
        }
    }
}
