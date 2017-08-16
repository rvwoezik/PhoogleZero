using System.Threading.Tasks;

namespace PhoogleZero.Security
{
    public interface IPasswordComplexitySettingStore
    {
        Task<PasswordComplexitySetting> GetSettingsAsync();
    }
}
