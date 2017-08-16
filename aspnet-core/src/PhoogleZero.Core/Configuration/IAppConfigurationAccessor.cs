using Microsoft.Extensions.Configuration;

namespace PhoogleZero.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
