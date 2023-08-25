using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.ViewComponents.Dashboard
{
    public class OneCikanStatistics : ViewComponent
    {
        Context c = new Context();
       
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Portföies.Count();
            ViewBag.v2 = c.Messages.Count();
            ViewBag.v3 = c.EkipTanitims.Count();
            ViewBag.v4 = c.Testimonials.Count();
            return View();
        }
    }
}
