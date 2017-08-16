using Abp.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;
using PhoogleZero.Authorization.Roles;
using PhoogleZero.Authorization.Users;
using PhoogleZero.MultiTenancy;

namespace PhoogleZero.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<IdentityOptions> options, 
            SignInManager signInManager) 
            : base(options, signInManager)
        {
        }
    }
}