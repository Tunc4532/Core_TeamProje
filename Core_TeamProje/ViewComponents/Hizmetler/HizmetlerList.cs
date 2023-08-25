using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.ViewComponents.Hizmetler
{
    public class HizmetlerList : ViewComponent
    {
        HizmetlerManager hhizmetlerManager = new HizmetlerManager(new EfHizmetlerDal());

        public IViewComponentResult Invoke()
        {
            var values = hhizmetlerManager.TGetList();
            return View(values);
        }

    }
}
