using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.Areas.User.ViewComponents
{
    

    public class TopPuroducts : ViewComponent
    {
        PortföyManager portföyManager = new PortföyManager(new EfPortföyDal());

        public IViewComponentResult Invoke()
        {
            var values = portföyManager.TGetList(); 
            return View(values);
        }

    }
}
