using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.ViewComponents.EkipTanitim
{
    public class EkipTanitimList : ViewComponent
    {
        EkipTanitimManager eekipTanitimManager = new EkipTanitimManager(new EfEkipTanitimDal());

        public IViewComponentResult Invoke()
        {
            var values = eekipTanitimManager.TGetList();
            return View(values);
        }

    }
}
