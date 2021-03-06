﻿using Abp.Dependency;
using Castle.MicroKernel.Registration;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PhoogleZero.EntityFrameworkCore;
using PhoogleZero.Identity;

namespace PhoogleZero.Tests.DependencyInjection
{
    public static class ServiceCollectionRegistrar
    {
        public static void Register(IIocManager iocManager)
        {
            RegisterIdentity(iocManager);

            var builder = new DbContextOptionsBuilder<PhoogleZeroDbContext>();

            var inMemorySqlite = new SqliteConnection("Data Source=:memory:");
            builder.UseSqlite(inMemorySqlite);

            iocManager.IocContainer.Register(
                Component
                    .For<DbContextOptions<PhoogleZeroDbContext>>()
                    .Instance(builder.Options)
                    .LifestyleSingleton()
            );

            inMemorySqlite.Open();
            new PhoogleZeroDbContext(builder.Options).Database.EnsureCreated();
        }

        private static void RegisterIdentity(IIocManager iocManager)
        {
            var services = new ServiceCollection();
            IdentityRegistrar.Register(services, "Tests");
            WindsorRegistrationHelper.CreateServiceProvider(iocManager.IocContainer, services);
        }
    }
}
