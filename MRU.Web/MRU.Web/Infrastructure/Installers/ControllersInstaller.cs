using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.MicroKernel.SubSystems.Configuration;
using System.Web.Mvc;
using MRU.Web.Infrastructure;

namespace Verge.VSuite.Web.Infrastructure.Installers
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