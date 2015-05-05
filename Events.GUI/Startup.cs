using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Events.GUI.Startup))]
namespace Events.GUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
