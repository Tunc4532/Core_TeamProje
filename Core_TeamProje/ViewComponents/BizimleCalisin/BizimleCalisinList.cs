using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Core_TeamProje.ViewComponents.BizimleCalisin
{
    public class BizimleCalisinList : ViewComponent
    {
        BizimleCalisinManager bbizimleCalisinManager = new BizimleCalisinManager(new EfBizimleCalisinDal());
        public IViewComponentResult Invoke()
        {
            var values = bbizimleCalisinManager.TGetList();
            return View(values);
        }

    }
}
