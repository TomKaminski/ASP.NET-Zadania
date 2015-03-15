#region

using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Zaj02MVC.Infrastructure;
using Zaj02MVC.Models;

#endregion

namespace Zaj02MVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            using (var db = new AppDbContext())
            {
                return View(new IndexViewModel
                {
                    IndexList = GetList(db)
                });
            }
        }

        [HttpPost]
        public ActionResult Index([Bind(Exclude = "Id", Prefix = "Formularz")] Formularz model)
        {
            using (var db = new AppDbContext())
            {
                if (!ModelState.IsValid)
                    return View(new IndexViewModel
                    {
                        Formularz = model,
                        IndexList = GetList(db)
                    });
                db.Formularze.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        private static List<IndexListModel> GetList(AppDbContext db)
        {
            return db.Formularze.Select(x => new IndexListModel
            {
                AuthorName = x.AuthorName,
                AuthorLastName = x.AuthorLastName,
                Email = x.AuthorEmail,
                DefenderName = x.DefenderName,
                DefenderLastName = x.DefenderLastName,
                SubAuthorName = x.SubAuthorName,
                SubAutorLastName = x.SubAuthorLastName,
                Title = x.ReportTitle
            }).ToList();
        }
    }
}