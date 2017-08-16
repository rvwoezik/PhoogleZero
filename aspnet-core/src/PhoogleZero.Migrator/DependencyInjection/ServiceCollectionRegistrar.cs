﻿using Abp.Dependency;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using PhoogleZero.Identity;

namespace PhoogleZero.Migrator.DependencyInjection
{
    public static class ServiceCollectionRegistrar
    {
        public static void Register(IIocManager iocManager)
        {
            var services = new ServiceCollection();

            IdentityRegistrar.Register(services, "Migrator");

            WindsorRegistrationHelper.CreateServiceProvider(iocManager.IocContainer, services);
        }
    }
}
