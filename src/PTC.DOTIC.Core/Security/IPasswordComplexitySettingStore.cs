using System.Threading.Tasks;

namespace PTC.DOTIC.Security
{
    public interface IPasswordComplexitySettingStore
    {
        Task<PasswordComplexitySetting> GetSettingsAsync();
    }
}
