using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PhoogleZero.Common.Dto;
using PhoogleZero.Editions.Dto;

namespace PhoogleZero.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}