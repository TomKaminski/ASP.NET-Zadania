using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zaj02.Startup))]
namespace Zaj02
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
