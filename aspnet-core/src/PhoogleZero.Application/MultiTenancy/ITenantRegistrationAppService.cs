using System.Threading.Tasks;
using Abp.Application.Services;
using PhoogleZero.Editions.Dto;
using PhoogleZero.MultiTenancy.Dto;

namespace PhoogleZero.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}