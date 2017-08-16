using System.Threading.Tasks;
using PhoogleZero.Sessions.Dto;

namespace PhoogleZero.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
