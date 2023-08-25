using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.Areas.User.ViewComponents
{
    public class Charts : ViewComponent
    {
        UzmanEkipManager uzmanEkip = new UzmanEkipManager(new EfUzmanEkipDal());

        public IViewComponentResult Invoke()
        {
            var values = uzmanEkip.TGetList();
            return View(values);
        }
    }
}
