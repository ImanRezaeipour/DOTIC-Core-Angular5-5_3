using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PTC.DOTIC.MultiTenancy.HostDashboard.Dto;

namespace PTC.DOTIC.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}