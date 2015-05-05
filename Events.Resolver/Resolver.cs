using System.Data.Entity;
using Autofac;
using Events.Contract.Service;
using Events.Dal.Model;
using Events.Dal.Repository;
using Events.Service;
using Module = Autofac.Module;

namespace Events.Resolver
{
    public  class ResolverModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(x => new RepositoryBase<EventTypes>()).As<IRepository<EventTypes>>();
            builder.RegisterType<EventService>().As<IEventService>();
            builder.RegisterType<EventsDataContext>().As<DbContext>().InstancePerLifetimeScope();
        }
    }
}

