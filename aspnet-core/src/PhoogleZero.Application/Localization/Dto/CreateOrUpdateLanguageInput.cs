using System.ComponentModel.DataAnnotations;

namespace PhoogleZero.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}