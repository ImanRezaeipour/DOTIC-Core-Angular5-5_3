using System.Collections.Generic;
using PTC.DOTIC.Auditing.Dto;
using PTC.DOTIC.Dto;

namespace PTC.DOTIC.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);
    }
}
