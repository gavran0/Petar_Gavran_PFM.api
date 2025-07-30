using Microsoft.EntityFrameworkCore;
using PFM.Application.DTO;
using PFM.Application.Services;
using PFM.Domain.Enums;
using PFM.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFM.Infrastructure.Services
{
    public class AnalyticsService : IAnalyticsService
    {
        private readonly PFMDbContext _context;

        public AnalyticsService(PFMDbContext context)
        {
            _context = context;
        }

        public async Task<List<SpendingAnalyticsItem>> GetSpendingAnalyticsAsync(
            string? category = null,
            DateTime? startDate = null,
            DateTime? endDate = null,
            Direction? direction = null)
        {
            var query = _context.Transactions
                .Join(
                    _context.Categories,
                    t => t.CatCode,
                    c => c.Code,
                    (t, c) => new
                    {
                        t.Amount,
                        t.Direction,
                        t.Date,
                        CategoryCode = c.Code,
                        CategoryName = c.Name
                    });

            if (!string.IsNullOrEmpty(category))
            {
                query = query.Where(x =>
                    x.CategoryCode == category || x.CategoryCode.StartsWith(category));
            }

            if (startDate.HasValue)
            {
                query = query.Where(x => x.Date >= startDate.Value.Date);
            }

            if (endDate.HasValue)
            {
                query = query.Where(x => x.Date <= endDate.Value.Date);
            }

            if (direction.HasValue)
            {
                query = query.Where(x => x.Direction == direction.Value);

                var grouped = await query
                    .GroupBy(x => new { x.CategoryCode, x.CategoryName, x.Direction })
                    .Select(g => new SpendingAnalyticsItem
                    {
                        CategoryCode = g.Key.CategoryCode,
                        CategoryName = g.Key.CategoryName,
                        Direction = g.Key.Direction,
                        TotalAmount = g.Sum(x => x.Amount)
                    })
                    .ToListAsync();

                return grouped;
            }
            else
            {
                var grouped = await query
                    .GroupBy(x => new { x.CategoryCode, x.CategoryName })
                    .Select(g => new SpendingAnalyticsItem
                    {
                        CategoryCode = g.Key.CategoryCode,
                        CategoryName = g.Key.CategoryName,
                        Direction = null,
                        TotalAmount = g.Sum(x => x.Amount)
                    })
                    .ToListAsync();

                return grouped;
            }
        }
    }
}
