using Abp.Dependency;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using PhoogleZero.Configuration;

namespace PhoogleZero.Web.Configuration
{
    public class AppConfigurationAccessor: IAppConfigurationAccessor, ISingletonDependency
    {
        public IConfigurationRoot Configuration { get; }

        public AppConfigurationAccessor(IHostingEnvironment env)
        {
            Configuration = env.GetAppConfiguration();
        }
    }
}
