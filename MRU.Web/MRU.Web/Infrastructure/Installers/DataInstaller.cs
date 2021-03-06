﻿using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.MicroKernel.SubSystems.Configuration;

namespace MRU.Web.Infrastructure.Installers
{
    public class DataInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromAssemblyNamed("MRU.Data")
                                .Where(type=>type.Name.EndsWith("Repository"))
                                .WithService.DefaultInterfaces()
                                .Configure(c => c.LifestyleTransient()));
        }
    }
}