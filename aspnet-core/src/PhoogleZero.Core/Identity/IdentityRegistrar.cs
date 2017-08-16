using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using PhoogleZero.Authentication.TwoFactor.Google;
using PhoogleZero.Authorization.Roles;
using PhoogleZero.Authorization.Users;
using PhoogleZero.MultiTenancy;

namespace PhoogleZero.Identity
{
    public static class IdentityRegistrar
    {
        private const string CookiePrefix = "Identity.PhoogleZero";

        public static void Register(IServiceCollection services, string cookiePostFix)
        {
            services.AddLogging();

            services.AddAbpIdentity<Tenant, User, Role>(options =>
                {
                    options.Cookies.ApplicationCookie.CookieName = CookiePrefix + "." + cookiePostFix;

                    options.Cookies.ExternalCookie.CookieName = CookiePrefix + ".External." + cookiePostFix;
                    options.Cookies.ExternalCookie.CookieName = CookiePrefix + ".TwoFactorRememberMe." + cookiePostFix;
                    options.Cookies.ExternalCookie.CookieName = CookiePrefix + ".TwoFactorUserId." + cookiePostFix;

                    options.Tokens.ProviderMap[GoogleAuthenticatorProvider.Name] = new TokenProviderDescriptor(typeof(GoogleAuthenticatorProvider));
                })
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddDefaultTokenProviders();
        }
    }
}
