using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.Areas.User.Controllers
{
    [Area("User")]
    [Authorize]
    public class UDefaultController : Controller
    {

        AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());

        public IActionResult Index()
        {
            var values = announcementManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AnnounccementDetails(int id)
        {
            Announcement valuesr = announcementManager.TGetByID(id);
            return View(valuesr);
        }
    }
}
