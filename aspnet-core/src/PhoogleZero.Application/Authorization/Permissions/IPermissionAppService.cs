using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PhoogleZero.Authorization.Permissions.Dto;

namespace PhoogleZero.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
