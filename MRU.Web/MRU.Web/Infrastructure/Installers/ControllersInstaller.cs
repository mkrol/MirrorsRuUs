using System.Web.Mvc;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace MRU.Web.Infrastructure
{
    public class ControllersInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            container.Register(Component.For<IActionInvoker>().ImplementedBy<WindsorActionInvoker>().LifeStyle.Transient);

            container.Register(Classes.FromThisAssembly()
                           .BasedOn<IController>()
                           .If(t => t.Name.EndsWith("Controller")).LifestyleTransient());


        }
    }
}