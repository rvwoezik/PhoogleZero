#if FEATURE_LDAP
using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using PhoogleZero.Authorization.Users;
using PhoogleZero.MultiTenancy;

namespace PhoogleZero.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}
#endif