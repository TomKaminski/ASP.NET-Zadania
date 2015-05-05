using Autofac;
using Zaj02MVC.Infrastructure.Concrete;
using Zaj02MVC.Infrastructure.Interfaces;

namespace Zaj02MVC.Modules
{
    public class RepositoryModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType(typeof (FormRepository)).As(typeof (IFormRepository)).InstancePerLifetimeScope();
        }
    }
}