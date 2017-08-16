using System.Threading.Tasks;
using Abp.Application.Services;
using PhoogleZero.Sessions.Dto;

namespace PhoogleZero.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
