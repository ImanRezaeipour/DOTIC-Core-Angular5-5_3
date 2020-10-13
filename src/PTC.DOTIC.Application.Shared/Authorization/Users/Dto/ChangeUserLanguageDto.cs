using System.ComponentModel.DataAnnotations;

namespace PTC.DOTIC.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
