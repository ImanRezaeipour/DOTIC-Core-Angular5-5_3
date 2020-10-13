using Abp.Application.Services;
using PTC.DOTIC.Dto;
using PTC.DOTIC.Logging.Dto;

namespace PTC.DOTIC.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
