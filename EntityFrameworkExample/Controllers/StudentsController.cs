using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using EntityFrameworkExample.Identity;

namespace EntityFrameworkExample.Controllers
{
    [RoutePrefix("Studenci")]
    public class StudentsController : Controller
    {
        private readonly AppDbContext _db = new AppDbContext();

        // GET: Students
        [Route("Lista", Name = "MainList")]
        [Route("List/{asd?}")]
        [Route("~/Asd/NieObchodziMnieRouting")]
        public ActionResult Index()
        {
            var students = _db.Students.Include(s => s.Address).Include(x=>x.Phones);
            return View(students.ToList());
        }

        // GET: Students/Details/5
        [Route("Szczegoly/{id:int=43571}")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var student = _db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // GET: Students/Create
        [Route("Create")]
        [Route("",Name="aletojestslabe")]
        public ActionResult Create()
        {
            ViewBag.NrIndeksu = new SelectList(_db.Addresses, "NrIndeksu", "Street");
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Create")]
        [Route("")]
        public ActionResult Create([Bind(Include = "NrIndeksu,Name,LastName")] Student student)
        {
            if (ModelState.IsValid)
            {
                _db.Students.Add(student);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.NrIndeksu = new SelectList(_db.Addresses, "NrIndeksu", "Street", student.NrIndeksu);
            return View(student);
        }

        // GET: Students/Edit/5
        [Route("Edytuj/Uzytkownik{id:int}")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = _db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            ViewBag.NrIndeksu = new SelectList(_db.Addresses, "NrIndeksu", "Street", student.NrIndeksu);
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Edytuj/Uzytkownik{id:int}")]
        public ActionResult Edit([Bind(Include = "NrIndeksu,Name,LastName")] Student student)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(student).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.NrIndeksu = new SelectList(_db.Addresses, "NrIndeksu", "Street", student.NrIndeksu);
            return View(student);
        }

        // GET: Students/Delete/5
        [Route("{id:int}/UsunMnie")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = _db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Route("{id:int}/UsunMnie")]
        public ActionResult DeleteConfirmed(int id)
        {
            Student student = _db.Students.Find(id);
            _db.Students.Remove(student);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
