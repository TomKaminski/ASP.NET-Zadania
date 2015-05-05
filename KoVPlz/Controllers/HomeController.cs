using System.Web.Mvc;

namespace KoVPlz.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(new[] { "1.jpg", "2.jpg", "3.jpg" });
        }
    }
}