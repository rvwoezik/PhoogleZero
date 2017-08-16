using Abp.Dependency;
using Abp.MultiTenancy;
using Microsoft.AspNetCore.Hosting;
using PhoogleZero.Url;
using PhoogleZero.Web.Url;

namespace PhoogleZero.Web.Public.Url
{
    public class WebUrlService : WebUrlServiceBase, IWebUrlService, ITransientDependency
    {
        public WebUrlService(
            IHostingEnvironment hostingEnvironment,
            ITenantCache tenantCache) :
            base(hostingEnvironment, tenantCache)
        {
        }

        public override string WebSiteRootAddressFormatKey => "App:WebSiteRootAddress";

        public override string ServerRootAddressFormatKey => "App:AdminWebSiteRootAddress";
    }
}