using Abp.AspNetCore.Mvc.ViewComponents;

namespace PhoogleZero.Web.Public.Views
{
    public abstract class PhoogleZeroViewComponent : AbpViewComponent
    {
        protected PhoogleZeroViewComponent()
        {
            LocalizationSourceName = PhoogleZeroConsts.LocalizationSourceName;
        }
    }
}