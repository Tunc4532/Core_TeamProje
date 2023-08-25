using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.Controllers
{
    public class TestimonialController : Controller
    {
        TestimonialManager ytestimonialManager = new TestimonialManager(new EfTestimonialDal());

        public IActionResult Index()
        {
            ViewBag.v1 = "Müşteri Paneli";
            ViewBag.v2 = "Listeleme ";
            ViewBag.v3 = "Müşteri Listeleme";
            var values = ytestimonialManager.TGetList();
            return View(values);
        }


        [HttpGet]
        public IActionResult AddTestimonial()
        {
            ViewBag.v1 = "Müşteri Paneli";
            ViewBag.v2 = "Ekleme ";
            ViewBag.v3 = "Müşteri Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            ytestimonialManager.TAdd(testimonial);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteTestimonial(int id)
        {
            var values = ytestimonialManager.TGetByID(id);
            ytestimonialManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditTestimonial(int id)
        {
            ViewBag.v1 = "Müşteri Paneli";
            ViewBag.v2 = "Güncelleme ";
            ViewBag.v3 = "Müşteri Güncelleme";
            var values = ytestimonialManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditTestimonial(Testimonial testimonial)
        {
            ytestimonialManager.TUpdate(testimonial);
            return RedirectToAction("Index");
        }
    }
}
