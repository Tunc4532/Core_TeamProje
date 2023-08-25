using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.Areas.User.ViewComponents
{
    public class CekipList : ViewComponent
    {
        EkipTanitimManager cevikEkip = new EkipTanitimManager(new EfEkipTanitimDal());

        public IViewComponentResult Invoke()
        {
            var values = cevikEkip.TGetList();
            return View(values);
        }
    }
}

