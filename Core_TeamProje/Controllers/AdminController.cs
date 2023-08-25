using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }

        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }

        public PartialViewResult NavigationPartial()
        {
            return PartialView();
        }
    }
}
