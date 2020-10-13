using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PTC.DOTIC.Auditing.Dto;
using PTC.DOTIC.Dto;

namespace PTC.DOTIC.Auditing
{
    public interface IAuditLogAppService : IApplicationService
    {
        Task<PagedResultDto<AuditLogListDto>> GetAuditLogs(GetAuditLogsInput input);

        Task<FileDto> GetAuditLogsToExcel(GetAuditLogsInput input);
    }
}