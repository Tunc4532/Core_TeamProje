using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.ViewComponents.UzmanEkip
{
    public class UzmanEkipList : ViewComponent
    {
        UzmanEkipManager uuzmanEkipManager = new UzmanEkipManager(new EfUzmanEkipDal());

        public IViewComponentResult Invoke()
        {
            var values = uuzmanEkipManager.TGetList();
            return View(values);
        }

    }
}
