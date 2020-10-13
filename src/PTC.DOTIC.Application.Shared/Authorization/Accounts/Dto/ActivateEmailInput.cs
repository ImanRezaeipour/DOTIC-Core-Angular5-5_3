using System.ComponentModel.DataAnnotations;

namespace PTC.DOTIC.Authorization.Accounts.Dto
{
    public class ActivateEmailInput
    {
        [Required]
        public long UserId { get; set; }

        [Required]
        public string ConfirmationCode { get; set; }
    }
}