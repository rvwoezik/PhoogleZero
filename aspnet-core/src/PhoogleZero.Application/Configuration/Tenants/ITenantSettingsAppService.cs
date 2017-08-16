using System.Threading.Tasks;
using Abp.Application.Services;
using PhoogleZero.Configuration.Tenants.Dto;

namespace PhoogleZero.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
