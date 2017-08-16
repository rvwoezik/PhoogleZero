using System.Threading.Tasks;
using Abp.Application.Services;
using PhoogleZero.Configuration.Host.Dto;

namespace PhoogleZero.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
