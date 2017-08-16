using System.ComponentModel.DataAnnotations;

namespace PhoogleZero.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
