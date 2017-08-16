using System.ComponentModel.DataAnnotations;
using PhoogleZero.Authorization.Users;

namespace PhoogleZero.Configuration.Host.Dto
{
    public class SendTestEmailInput
    {
        [Required]
        [MaxLength(User.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
    }
}