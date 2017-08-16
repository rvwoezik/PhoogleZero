using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace PhoogleZero.Web.Public.Views
{
    public abstract class PhoogleZeroRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected PhoogleZeroRazorPage()
        {
            LocalizationSourceName = PhoogleZeroConsts.LocalizationSourceName;
        }
    }
}
