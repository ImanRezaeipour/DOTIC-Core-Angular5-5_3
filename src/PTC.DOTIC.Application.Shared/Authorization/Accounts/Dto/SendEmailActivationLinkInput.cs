using System.ComponentModel.DataAnnotations;

namespace PTC.DOTIC.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}