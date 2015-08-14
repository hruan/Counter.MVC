using System.Reflection;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Counter.Controllers;

namespace Counter
{
    public static class DependencyResolverConfig
    {
        public static void Configure()
        {
#if DEBUG
            LocalConfiguration.SetEnvironmentVariables();
#endif
            var builder = new ContainerBuilder();
            builder.RegisterType<ApplicationConfigurationFromEnvironment>().AsImplementedInterfaces();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}