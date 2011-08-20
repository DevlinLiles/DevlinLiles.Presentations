using System.Data.Entity;
using System.Web.Mvc;
using BeautifulUI.Controllers;
using BeautifulUI.Properties;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Core.Interfaces;
using Infrastructure;
using Infrastructure.IoC;

namespace BeautifulUI.IoC
{
    public static class WindsorConfiguration
    {
         public static WindsorContainer Configure(this WindsorContainer container, string connectionString)
         {
             container.Register(Component.For<IControllerActivator>().ImplementedBy<WindsorControllerActivator>());
             container.Register(Component.For<HomeController>().ImplementedBy<HomeController>().LifeStyle.Transient);
             container.Register(Component.For<IRepository>().ImplementedBy<EntityFrameworkRepository>());
             container.Register(Component.For<DbContext>().ImplementedBy<AdventureWorksContext>().Parameters(Parameter.ForKey("connectionString").Eq(Settings.Default.Connection)));
             return container;
         }
    }
}