﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web;
using Ninject;
using Ninject.Modules;

namespace DevFramework.Core.Utilities.Mvc.Infrastructure
{
   public class NinjectControllerFactory:DefaultControllerFactory
    {
        IKernel _kernel;
        public NinjectControllerFactory(INinjectModule module)
        {
            _kernel = new StandardKernel(module);
        }
        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)_kernel.Get(controllerType);
        }
    }
}
