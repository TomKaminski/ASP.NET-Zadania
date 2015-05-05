#region

using System.Linq;
using System.Web.Mvc;
using Zaj02MVC.BLL.Concrete;
using Zaj02MVC.BLL.Interfaces;
using Zaj02MVC.ViewModels;

#endregion

namespace Zaj02MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFormService _formService;

        public HomeController(IFormService formService)
        {
            _formService = formService;
        }


        [HttpGet]
        public ActionResult Index()
        {
            return View(new IndexViewModel
            {
                Formularz = new AddReportModel(),
                IndexList = _formService.GetList().ToList()
            });

        }

        [HttpPost]
        public ActionResult Index(AddReportModel model)
        {
            if (!ModelState.IsValid)
                return View(new IndexViewModel
                {
                    Formularz = model,
                    IndexList = _formService.GetList().ToList()
                });
            _formService.RegisterForm(model);
            return RedirectToAction("Index");
        }        
    }
}