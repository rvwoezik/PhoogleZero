using System.Threading.Tasks;

namespace PhoogleZero.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}