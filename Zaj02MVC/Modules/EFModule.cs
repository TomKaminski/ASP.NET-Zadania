using System.Data.Entity;
using Autofac;
using Zaj02MVC.Infrastructure.Concrete;
using Zaj02MVC.Infrastructure.Context;
using Zaj02MVC.Infrastructure.Interfaces;

namespace Zaj02MVC.Modules
{
    public class EfModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new RepositoryModule());

            builder.RegisterType(typeof(AppDbContext)).As(typeof(DbContext)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork)).InstancePerRequest();      
            base.Load(builder);
        }
    }
}