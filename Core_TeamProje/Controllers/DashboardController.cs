using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Dashboard List";
            ViewBag.v2 = "Dashboard ";
            ViewBag.v3 = "Mesajlar";
            return View();
        }

    }
}
