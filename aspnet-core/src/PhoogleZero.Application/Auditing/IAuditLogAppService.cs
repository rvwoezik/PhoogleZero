using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PhoogleZero.Auditing.Dto;
using PhoogleZero.Dto;

namespace PhoogleZero.Auditing
{
    public interface IAuditLogAppService : IApplicationService
    {
        Task<PagedResultDto<AuditLogListDto>> GetAuditLogs(GetAuditLogsInput input);

        Task<FileDto> GetAuditLogsToExcel(GetAuditLogsInput input);
    }
}