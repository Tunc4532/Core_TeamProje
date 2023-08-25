using Core_TeamProje.Areas.User.Models;
using DataAccessLayer.Concrete;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.Areas.User.Controllers
{
    [Area("User")]
    public class DashboardUserController : Controller
    {

        private readonly UserManager<WriterUser> _userManager;

        public DashboardUserController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v1 = values.Namet + " " + values.SurNamet;


            //Statistics
            Context c = new Context();
            ViewBag.d1 = c.WriterMessages.Where(x => x.Alici == values.Email).Count();
            ViewBag.d2 = c.Announcements.Count();
            ViewBag.d3 = c.Users.Count();
            ViewBag.d4 = c.Hizmetlers.Count();

            return View();
        } 
    }
}
