using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.Areas.User.ViewComponents
{
    public class Notificaton : ViewComponent
    {
        AnnouncementManager eannouncementManager = new AnnouncementManager(new EfAnnouncementDal());

        public IViewComponentResult Invoke()
        {
            var values = eannouncementManager.TGetList();
            return View(values);
        }

    }
}
