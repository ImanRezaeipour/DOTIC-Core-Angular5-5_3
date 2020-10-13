using System.ComponentModel.DataAnnotations;

namespace PTC.DOTIC.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}