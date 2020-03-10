using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace GymApp.Website.Modules
{
    public class ServiceModule : Autofac.Module
    {

        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterAssemblyTypes(Assembly.Load("GymApp.Service"))

                      .Where(t => t.Name.EndsWith("Service"))

                      .AsImplementedInterfaces()

                      .InstancePerLifetimeScope();

        }

    }
}