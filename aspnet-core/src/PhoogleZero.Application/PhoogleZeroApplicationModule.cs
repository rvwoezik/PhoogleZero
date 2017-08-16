using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PhoogleZero.Authorization;

namespace PhoogleZero
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(PhoogleZeroCoreModule)
        )]
    public class PhoogleZeroApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PhoogleZeroApplicationModule).GetAssembly());
        }
    }
}