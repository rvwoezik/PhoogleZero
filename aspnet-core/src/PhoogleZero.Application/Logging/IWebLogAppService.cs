using Abp.Application.Services;
using PhoogleZero.Dto;
using PhoogleZero.Logging.Dto;

namespace PhoogleZero.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
