using PFM.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PFM.Domain.Enums;

namespace PFM.Application.Services
{
    public interface IAnalyticsService
    {
        Task<List<SpendingAnalyticsItem>> GetSpendingAnalyticsAsync(string? categoryCode, DateTime? startDate, DateTime? endDate, Direction? direction);
    }

}
