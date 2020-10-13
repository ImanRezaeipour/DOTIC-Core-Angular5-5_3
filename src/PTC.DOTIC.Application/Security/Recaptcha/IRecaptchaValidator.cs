using System.Threading.Tasks;

namespace PTC.DOTIC.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}