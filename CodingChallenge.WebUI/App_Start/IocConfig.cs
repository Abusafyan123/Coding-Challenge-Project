using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Autofac.Integration.Mvc;
using Autofac;
using CodingChallenge.Repository;
using CodingChallenge.Service.Implementation;
using CodingChallenge.Service.Interfaces;

namespace CodingChallenge.WebUI
{
    public class IocConfig
    {
        public static void SetUpAutoFac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerHttpRequest();

            builder.RegisterType<CARRIER_Service>().As<ICARRIER_Service>().InstancePerHttpRequest();
            builder.RegisterType<SHIPMENT_RATE_Service>().As<ISHIPMENT_RATE_Service>().InstancePerHttpRequest();
            builder.RegisterType<SHIPMENT_Service>().As<ISHIPMENT_Service>().InstancePerHttpRequest();
            builder.RegisterType<SHIPPER_Service>().As<ISHIPPER_Service>().InstancePerHttpRequest();
            builder.RegisterType<SystemLookupService>().As<ISystemLookupService>().InstancePerHttpRequest();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterModelBinders(Assembly.GetExecutingAssembly());
            builder.RegisterModelBinderProvider();
            builder.RegisterFilterProvider();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}