using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.ViewComponents.Testimonial
{
    public class TestimonialList : ViewComponent
    {
        TestimonialManager ttestimonialManager = new TestimonialManager(new EfTestimonialDal());

        public IViewComponentResult Invoke()
        {
            var values = ttestimonialManager.TGetList();
            return View(values);
        }
    }
}
