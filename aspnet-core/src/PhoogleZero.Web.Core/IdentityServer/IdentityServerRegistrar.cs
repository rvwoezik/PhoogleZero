using Abp.IdentityServer4;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PhoogleZero.Authorization.Users;
using PhoogleZero.EntityFrameworkCore;

namespace PhoogleZero.Web.IdentityServer
{
    public static class IdentityServerRegistrar
    {
        public static void Register(IServiceCollection services, IConfigurationRoot configuration)
        {
            services.AddIdentityServer()
                .AddTemporarySigningCredential()
                .AddInMemoryIdentityResources(IdentityServerConfig.GetIdentityResources())
                .AddInMemoryApiResources(IdentityServerConfig.GetApiResources())
                .AddInMemoryClients(IdentityServerConfig.GetClients(configuration))
                .AddAbpPersistedGrants<PhoogleZeroDbContext>()
                .AddAbpIdentityServer<User>();
        }
    }
}
