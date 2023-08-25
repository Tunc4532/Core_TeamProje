using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.ViewComponents.Dashboard
{
    public class Last5Projects : ViewComponent
    {
        UzmanEkipManager ekipManager = new UzmanEkipManager(new EfUzmanEkipDal());


        public IViewComponentResult Invoke()
        {
            var valuesss = ekipManager.TGetList();
            return View(valuesss);
        }

    }
}
