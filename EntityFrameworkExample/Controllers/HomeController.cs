using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameworkExample.Controllers
{
    [RoutePrefix("Home")]
    [Route("{action=index}")]
    public class HomeController : Controller
    {
        // GET: Home
        [Route("Index")]
        [Route("~/")]
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }
    }
}