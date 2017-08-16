using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PhoogleZero.Authorization.Users.Dto;

namespace PhoogleZero.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<ListResultDto<UserLoginAttemptDto>> GetRecentUserLoginAttempts();
    }
}
