using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Services;
using Zaj02.Infrastructure;

namespace Zaj02
{
    public partial class Validation : System.Web.UI.Page
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

        protected void RegisterReport(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                db.Formularze.Add(new Formularz
                {
                    AuthorEmail = Email.Text,
                    DefenderLastName = DefenderLastName.Text,
                    DefenderName = DefenderName.Text,
                    AuthorLastName = AuthorLastName.Text,
                    SubAuthorName = SemiAuthorName.Text,
                    SubAuthorLastName = SemiAuthorLastName.Text,
                    UniversityAddress = universityAddress.Text,
                    UniversityName = universytyName.Text,
                    ReportSummary = reportSummary.Value,
                    ReportTitle = reportTitle.Text,
                    AuthorName = AuthorName.Text
                });
                db.SaveChanges();
                var plz = db.Formularze.Select(x => x).ToList();
                Repeater1.DataSource = plz;
                Repeater1.DataBind();
                ClearForm();
            }
        }
        protected void ClearForm()
        {
            Email.Text = string.Empty;
            DefenderLastName.Text = string.Empty;
            DefenderName.Text = string.Empty;
            AuthorLastName.Text = string.Empty;
            SemiAuthorName.Text = string.Empty;
            SemiAuthorLastName.Text = string.Empty;
            universytyName.Text = string.Empty;
            reportTitle.Text = string.Empty;
            AuthorName.Text = string.Empty;
            universityAddress.Text = string.Empty;
            reportSummary.Value = string.Empty;

        }

        [WebMethod]
        public static List<Formularz> ReturnData()
        {
            using (var db = new AppDbContext())
            {
                return db.Formularze.Select(x => x).ToList();
            }
        }
    }
}