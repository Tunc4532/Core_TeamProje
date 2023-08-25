using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.Areas.User.ViewComponents
{
    public class MGorusuare : ViewComponent
    {
        TestimonialManager testimonial = new TestimonialManager(new EfTestimonialDal());

        public IViewComponentResult Invoke()
        {
            var values = testimonial.TGetList();
            return View(values);
        }
    }
}
