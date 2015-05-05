using Autofac;
using Zaj02MVC.BLL.Concrete;
using Zaj02MVC.BLL.Interfaces;

namespace Zaj02MVC.Modules
{
    public class ServicesModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType(typeof (FormService)).As(typeof (IFormService)).InstancePerLifetimeScope();
        }
    }
}