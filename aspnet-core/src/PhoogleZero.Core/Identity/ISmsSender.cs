using System.Threading.Tasks;

namespace PhoogleZero.Identity
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}