using System;
using System.Linq;
using System.Web.UI;
using Zaj02.Infrastructure;

namespace Zaj02
{
    public partial class ValidationFormView : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                var plz = db.Formularze.Select(x => x).ToList();
                Repeater1.DataSource = plz;
                Repeater1.DataBind();
            }
        }

        public void ReportSubmit(Formularz model)
        {
            using (var db = new AppDbContext())
            {
                db.Formularze.Add(model);
                db.SaveChanges();
                var plz = db.Formularze.Select(x => x).ToList();
                Repeater1.DataSource = plz;
                Repeater1.DataBind();
            }
        }
    }
}
