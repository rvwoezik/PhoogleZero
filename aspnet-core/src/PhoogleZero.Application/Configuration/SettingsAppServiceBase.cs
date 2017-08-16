using System.Threading.Tasks;
using Abp.Net.Mail;
using PhoogleZero.Configuration.Host.Dto;

namespace PhoogleZero.Configuration
{
    public abstract class SettingsAppServiceBase : PhoogleZeroAppServiceBase
    {
        private readonly IEmailSender _emailSender;

        protected SettingsAppServiceBase(
            IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        #region Send Test Email

        public async Task SendTestEmail(SendTestEmailInput input)
        {
            await _emailSender.SendAsync(
                input.EmailAddress,
                L("TestEmail_Subject"),
                L("TestEmail_Body")
            );
        }

        #endregion
    }
}
