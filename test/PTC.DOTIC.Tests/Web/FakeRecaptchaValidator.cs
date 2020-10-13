using System.Threading.Tasks;
using PTC.DOTIC.Security.Recaptcha;

namespace PTC.DOTIC.Tests.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
