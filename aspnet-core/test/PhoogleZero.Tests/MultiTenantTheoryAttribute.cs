using Xunit;

namespace PhoogleZero.Tests
{
    public sealed class MultiTenantTheoryAttribute : TheoryAttribute
    {
        public MultiTenantTheoryAttribute()
        {
            if (!PhoogleZeroConsts.MultiTenancyEnabled)
            {
                Skip = "MultiTenancy is disabled.";
            }
        }
    }
}