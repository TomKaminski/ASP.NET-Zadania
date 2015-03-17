using System.Web.Mvc;

namespace KoVPlz.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult ReturnData()
        {
            return Json(new[] {"1.jpg", "2.jpg", "3.jpg"}, JsonRequestBehavior.AllowGet);
        }
    }
}