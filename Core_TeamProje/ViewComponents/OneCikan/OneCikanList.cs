using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.ViewComponents.OneCikan
{
    public class OneCikanList : ViewComponent
    {
        OneCikanManager ooneCikanManager = new OneCikanManager(new EfOneCikanDal());

        public IViewComponentResult Invoke()
        {
            var values = ooneCikanManager.TGetList();
            return View(values);
        }

    }
}
