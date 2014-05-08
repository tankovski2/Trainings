using System.Linq;
using MvcIoC.Models;
using MvcIoC.Pages;

[assembly: WebActivator.PreApplicationStartMethod(typeof(MvcIoC.App_Start.SimpleInjectorInitializer), "Initialize")]

namespace MvcIoC.App_Start
{
    using System.Reflection;
    using System.Web.Mvc;

    using SimpleInjector;
    using SimpleInjector.Integration.Web.Mvc;
    
    public static class SimpleInjectorInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            // Did you know the container can diagnose your configuration? Go to: http://bit.ly/YE8OJj.
            var container = new Container();
            
            InitializeContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            
            container.RegisterMvcAttributeFilterProvider();
       
            container.Verify();
            
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
     
        private static void InitializeContainer(Container container)
        {
            var repositoryAssembly = typeof (MvcApplication).Assembly;

            var registrations =
                from type in repositoryAssembly.GetExportedTypes()
                where type.Namespace.Contains("MvcIoC.Models")
                where type.GetInterfaces().Any()
                select new
                           {
                               Service = type.GetInterfaces().First(),
                               Implementation = type
                           };

            foreach (var reg in registrations)
            {
                container.Register(reg.Service, reg.Implementation, Lifestyle.Transient);
            }

            container.RegisterInitializer<ProteinTrackerBasePage>(
                p => p.AnalyticsService = container.GetInstance<IAnalyticsService>());

            // For instance:
            // container.Register<IUserRepository, SqlUserRepository>();
        }
    }
}