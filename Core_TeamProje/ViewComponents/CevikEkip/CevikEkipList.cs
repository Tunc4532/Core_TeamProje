using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.ViewComponents.CevikEkip
{
    public class CevikEkipList : ViewComponent
    {
        CevikEkipManager ccevikEkipManager = new CevikEkipManager(new EfCevikEkipDal());

        public IViewComponentResult Invoke()
        {
            var values = ccevikEkipManager.TGetList();
            return View(values);
        }

    }
}
