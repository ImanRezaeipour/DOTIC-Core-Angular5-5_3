using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PTC.DOTIC.Caching.Dto;

namespace PTC.DOTIC.Caching
{
    public interface ICachingAppService : IApplicationService
    {
        ListResultDto<CacheDto> GetAllCaches();

        Task ClearCache(EntityDto<string> input);

        Task ClearAllCaches();
    }
}
