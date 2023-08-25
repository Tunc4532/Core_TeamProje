using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.ViewComponents.Contact
{
    public class ContactDetails : ViewComponent
    {
        ContactManager ccontactManager = new ContactManager(new EfContactDal());

        public IViewComponentResult Invoke()
        {
            var values = ccontactManager.TGetList();
            return View(values);
        }
    }
}
