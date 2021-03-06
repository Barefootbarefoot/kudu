﻿using System;
using System.Web;
using Ninject.Activation;
using Ninject.Components;
using Ninject.Web.Common;

namespace Kudu.Services.Web.Services
{
    public class NinjectHttpApplicationPlugin : NinjectComponent, INinjectHttpApplicationPlugin
    {
        public NinjectHttpApplicationPlugin()
        {
        }

        public override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public object GetRequestScope(IContext context)
        {
            return HttpContext.Current;
        }

        public void Start()
        {
            // No-op
        }

        public void Stop()
        {
            // No-op
        }
    }
}