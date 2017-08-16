using System.Collections.Generic;
using PhoogleZero.Auditing.Dto;
using PhoogleZero.Dto;

namespace PhoogleZero.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);
    }
}
