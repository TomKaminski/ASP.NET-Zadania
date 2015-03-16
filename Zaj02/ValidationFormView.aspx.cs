using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Zaj02.Infrastructure;

namespace Zaj02
{
    public partial class ValidationFormView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.WebForms;
            
        }

        public void ReportSubmit(Formularz model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new AppDbContext())
                {
                    db.Formularze.Add(model);
                    db.SaveChanges();
                }
            }
        }
    }
}