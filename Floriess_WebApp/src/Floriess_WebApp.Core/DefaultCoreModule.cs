using Autofac;
using Floriess_WebApp.Core.Interfaces;
using Floriess_WebApp.Core.Services;

namespace Floriess_WebApp.Core
{
    public class DefaultCoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ToDoItemSearchService>()
                .As<IToDoItemSearchService>().InstancePerLifetimeScope();
        }
    }
}