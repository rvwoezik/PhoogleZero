using System.Threading.Tasks;
using PhoogleZero.Security.Recaptcha;

namespace PhoogleZero.Tests.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public async Task ValidateAsync(string captchaResponse)
        {
            
        }
    }
}
