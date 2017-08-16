using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;
using PhoogleZero.Configuration;
using PhoogleZero.EntityFrameworkCore;
using PhoogleZero.Migrator.DependencyInjection;

namespace PhoogleZero.Migrator
{
    [DependsOn(typeof(PhoogleZeroEntityFrameworkCoreModule))]
    public class PhoogleZeroMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public PhoogleZeroMigratorModule(PhoogleZeroEntityFrameworkCoreModule abpZeroTemplateEntityFrameworkCoreModule)
        {
            abpZeroTemplateEntityFrameworkCoreModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(PhoogleZeroMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                PhoogleZeroConsts.ConnectionStringName
                );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PhoogleZeroMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}