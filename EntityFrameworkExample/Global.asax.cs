using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using EntityFrameworkExample.Identity;

namespace EntityFrameworkExample
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(new AppDbContext.AppDbInitializer());
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
