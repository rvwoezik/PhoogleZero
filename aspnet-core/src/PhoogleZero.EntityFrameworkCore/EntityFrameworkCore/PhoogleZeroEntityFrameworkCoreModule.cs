using Abp.EntityFrameworkCore.Configuration;
using Abp.IdentityServer4;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using PhoogleZero.Migrations.Seed;

namespace PhoogleZero.EntityFrameworkCore
{
    /// <summary>
    /// Entity framework Core module of the application.
    /// </summary>
    [DependsOn(
        typeof(AbpZeroCoreEntityFrameworkCoreModule), 
        typeof(PhoogleZeroCoreModule), 
        typeof(AbpZeroCoreIdentityServerEntityFrameworkCoreModule)
        )]
    public class PhoogleZeroEntityFrameworkCoreModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<PhoogleZeroDbContext>(configuration =>
                {
                    PhoogleZeroDbContextConfigurer.Configure(configuration.DbContextOptions, configuration.ConnectionString);
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PhoogleZeroEntityFrameworkCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
