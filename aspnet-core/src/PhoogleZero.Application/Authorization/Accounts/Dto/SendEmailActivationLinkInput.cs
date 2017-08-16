using System.ComponentModel.DataAnnotations;

namespace PhoogleZero.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}