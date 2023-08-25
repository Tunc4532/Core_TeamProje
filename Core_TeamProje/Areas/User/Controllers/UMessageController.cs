using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_TeamProje.Areas.User.Controllers
{
    [Area("User")]
    [Route("User/UMessage")]
    public class UMessageController : Controller
    {
        WriterMessageManager ewriterMessageManager = new WriterMessageManager(new EfWriterMessageDal());

        private readonly UserManager<WriterUser> _userManager;

        public UMessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [Route("")]
        [Route("ReceiverMessage")]
        public async Task <IActionResult> ReceiverMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messagelist = ewriterMessageManager.GetListAliciMessage(p);
            return View(messagelist);
        }

        [Route("")]
        [Route("SenderMessage")]
        public async Task<IActionResult> SenderMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messagelist = ewriterMessageManager.GetListGonderenMessage(p);
            return View(messagelist);
        }

        [Route("MessageDetails/{id}")]
        public IActionResult MessageDetails(int id)
        {
            WriterMessage writerMessage = ewriterMessageManager.TGetByID(id);
            return View(writerMessage);
        }

        [Route("ReceiverMessageDetails/{id}")]
        public IActionResult ReceiverMessageDetails(int id)
        {
            WriterMessage writerMessage = ewriterMessageManager.TGetByID(id);
            return View(writerMessage);
        }

        [HttpGet]
        [Route("")]
        [Route("SendMessage")]
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        [Route("")]
        [Route("SendMessage")]
        public async Task<IActionResult> SendMessage(WriterMessage p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string mail = values.Email;
            string name = values.Namet + " " + values.SurNamet;
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Gonderen = mail;
            p.Gonderenadi = name;
            Context c = new Context();
            var usernamesurmane = c.Users.Where(x => x.Email == p.Alici).Select(y => y.Namet +  " " + y.SurNamet).FirstOrDefault();
            p.Aliciadi = usernamesurmane;
            //p.Gonderenadi = usernamesurmane;
            ewriterMessageManager.TAdd(p);
            return RedirectToAction("SenderMessage");
        }
    }
}
