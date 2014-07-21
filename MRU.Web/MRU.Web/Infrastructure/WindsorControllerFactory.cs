﻿using Castle;
using Castle.MicroKernel;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System;

namespace MRU.Web.Infrastructure
{

    public class WindsorControllerFactory : DefaultControllerFactory
    {
        private readonly IKernel kernel;

        public WindsorControllerFactory(IKernel kernel)
        {
            this.kernel = kernel;
        }

        public override void ReleaseController(IController controller)
        {
            kernel.ReleaseComponent(controller);
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            if (controllerType == null)
            {
                throw new HttpException(404, string.Format("The controller for path '{0}' could not be found.", requestContext.HttpContext.Request.Path));
            }
            else
            {
                IController iController = (IController)kernel.Resolve(controllerType);

                // new code    
                if (iController is Controller)
                {
                    ((Controller)iController).ActionInvoker = kernel.Resolve<IActionInvoker>();
                }

                return iController;
            }
        }
    }
}