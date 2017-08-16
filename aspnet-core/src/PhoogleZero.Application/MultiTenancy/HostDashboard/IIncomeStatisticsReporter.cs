using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PhoogleZero.MultiTenancy.HostDashboard.Dto;

namespace PhoogleZero.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}