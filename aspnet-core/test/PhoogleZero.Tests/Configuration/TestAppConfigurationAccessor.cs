using Abp.Dependency;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Configuration;
using PhoogleZero.Configuration;

namespace PhoogleZero.Tests.Configuration
{
    public class TestAppConfigurationAccessor : IAppConfigurationAccessor, ISingletonDependency
    {
        public IConfigurationRoot Configuration { get; }

        public TestAppConfigurationAccessor()
        {
            Configuration = AppConfigurations.Get(
                typeof(PhoogleZeroTestModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }
    }
}
