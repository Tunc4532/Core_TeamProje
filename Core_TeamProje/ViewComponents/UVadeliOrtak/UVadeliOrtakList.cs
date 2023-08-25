using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.ViewComponents.UVadeliOrtak
{
    public class UVadeliOrtakList : ViewComponent
    {
        UVadeliOrtakManager uuVadeliOrtakManager = new UVadeliOrtakManager(new EfUVadeliOrtakDal());

        public IViewComponentResult Invoke()
        {
            var values = uuVadeliOrtakManager.TGetList();
            return View(values);
        }
    }
}
