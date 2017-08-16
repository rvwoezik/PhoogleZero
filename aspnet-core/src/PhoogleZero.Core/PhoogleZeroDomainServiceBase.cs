using Abp.Domain.Services;

namespace PhoogleZero
{
    public abstract class PhoogleZeroDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected PhoogleZeroDomainServiceBase()
        {
            LocalizationSourceName = PhoogleZeroConsts.LocalizationSourceName;
        }
    }
}
