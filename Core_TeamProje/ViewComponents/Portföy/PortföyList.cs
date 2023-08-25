using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.ViewComponents.Portföy
{
    public class PortföyList : ViewComponent
    {
        PortföyManager pportföyManager = new PortföyManager(new EfPortföyDal());

        public IViewComponentResult Invoke()
        {
            var values = pportföyManager.TGetList();
            return View(values);
        }

    }
}
