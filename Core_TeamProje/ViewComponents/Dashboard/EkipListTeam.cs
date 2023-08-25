using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.ViewComponents.Dashboard
{
    public class EkipListTeam : ViewComponent
    {
        EkipTanitimManager tanitimManager = new EkipTanitimManager(new EfEkipTanitimDal());


        public IViewComponentResult Invoke()
        {
            var values = tanitimManager.TGetList();
            return View(values);
        }
    }
}
