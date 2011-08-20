using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace Infrastructure.IoC
{
    public class WindsorControllerActivator : IControllerActivator
    {
        public IController Create(RequestContext requestContext, Type controllerType)
        {
            return (IController) DependencyResolver.Current.GetService(controllerType);
        }
    }
}