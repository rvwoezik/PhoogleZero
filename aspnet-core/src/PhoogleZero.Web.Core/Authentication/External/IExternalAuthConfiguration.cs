using System.Collections.Generic;

namespace PhoogleZero.Web.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}