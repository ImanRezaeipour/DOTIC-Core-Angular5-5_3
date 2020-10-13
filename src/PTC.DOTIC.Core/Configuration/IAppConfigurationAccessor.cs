using Microsoft.Extensions.Configuration;

namespace PTC.DOTIC.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
