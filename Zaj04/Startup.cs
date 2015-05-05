using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zaj04.Startup))]
namespace Zaj04
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
