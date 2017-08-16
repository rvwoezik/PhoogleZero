using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Threading.BackgroundWorkers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using PhoogleZero.Configuration;
using PhoogleZero.MultiTenancy;

namespace PhoogleZero.Web.Startup
{
    [DependsOn(
        typeof(PhoogleZeroWebCoreModule))]
    public class PhoogleZeroWebHostModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PhoogleZeroWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Modules.AbpWebCommon().MultiTenancy.DomainFormat = _appConfiguration["App:ServerRootAddress"] ?? "http://localhost:22742/";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PhoogleZeroWebHostModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (IocManager.Resolve<IMultiTenancyConfig>().IsEnabled)
            {
                var workManager = IocManager.Resolve<IBackgroundWorkerManager>();
                workManager.Add(IocManager.Resolve<SubscriptionExpirationCheckWorker>());
                workManager.Add(IocManager.Resolve<SubscriptionExpireEmailNotifierWorker>());
            }
        }
    }
}
