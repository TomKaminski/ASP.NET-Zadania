using System.Linq;
using System.Web.Mvc;
using System.Xml.Linq;
using Zaj01.Models;

namespace Zaj01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var root = XElement.Load("http://news.google.com/news?pz=1&cf=all&ned=us&hl=en&output=rss");

            return View(root.Descendants("item").Select(x => new RssItem
            {
                Title = x.Element("title").Value,
                Description = x.Element("description").Value
            }).ToList());
        }

        public ActionResult GetRssItem()
        {
            return Index();
        }
    }
}