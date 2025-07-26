using PFM.Application.Models;
using PFM.Application.Services;
using PFM.Domain.Entities;
using PFM.Application.DTO;
using PFM.Domain.Enums;
using PFM.Application.Exceptions;
using PFM.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFM.Infrastructure.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly PFMDbContext _context;

        public TransactionService(PFMDbContext context)
        {
            _context = context;
        }

        public async Task<PagedResult<TransactionDto>> GetTransactionsAsync(
            DateTime? startDate,
            DateTime? endDate,
            string? kind,
            int page,
            int pageSize)
        {
            var query = _context.Transactions.Include(t => t.Category).Include(t => t.Splits).AsQueryable();

            if (startDate.HasValue)
                query = query.Where(t => t.Date >= startDate.Value.Date);

            if (endDate.HasValue)
                query = query.Where(t => t.Date <= endDate.Value.Date);

            //if (kind != null && kind.Any())
            //{
            //    var parsedKinds = kind
            //        .Select(k => Enum.TryParse<TransactionKind>(k, true, out var kind) ? (TransactionKind?)kind : null)
            //        .Where(k => k.HasValue)
            //        .Select(k => k.Value)
            //        .ToList();

            //    query = query.Where(t => parsedKinds.Contains(t.Kind));
            //}

            if (!string.IsNullOrWhiteSpace(kind) && Enum.TryParse<TransactionKind>(kind, true, out var parsedKind))
            {
                query = query.Where(t => t.Kind == parsedKind);
            }

            var total = await query.CountAsync();

            var items = await query
                .OrderByDescending(t => t.Date)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(t => new TransactionDto
                {
                    Id = t.Id,
                    CatCode = t.CatCode,
                    CategoryName = t.Category != null ? t.Category.Name : null,
                    Amount = t.Amount,
                    Date = t.Date,
                    Direction = t.Direction,
                    Description = t.Description,
                    Kind = t.Kind,
                    Splits = t.Splits.Select(s => new TransactionSplitDto
                    {
                        Amount = s.Amount,
                        CatCode = s.CatCode
                    }).ToList()
                })
                .ToListAsync();


            return new PagedResult<TransactionDto>
            {
                TotalCount = total,
                Page = page,
                PageSize = pageSize,
                Items = items
            };
        }

        public async Task<bool> CategorizeTransactionAsync(string transactionId, string categoryCode)
        {
            var transaction = await _context.Transactions.FindAsync(transactionId);
            if (transaction == null)
                return false;

            var categoryExists = await _context.Categories.AnyAsync(c => c.Code == categoryCode);
            if (!categoryExists)
                return false;

            transaction.CatCode = categoryCode;
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> SplitTransactionAsync(string transactionId, List<TransactionSplitDto> splits)
        {
            var transaction = await _context.Transactions
                .Include(t => t.Splits)
                .FirstOrDefaultAsync(t => t.Id == transactionId);

            if (transaction == null)
                return false;

            // Validacija svih kategorija
            var validCodes = await _context.Categories
                .Where(c => splits.Select(s => s.CatCode).Contains(c.Code))
                .Select(c => c.Code)
                .ToListAsync();

            if (validCodes.Count != splits.Count)
                throw new BusinessValidationException("One or more category codes are invalid.", 440);

            // Validacija suma
            var totalSplitAmount = splits.Sum(s => s.Amount);
            if (totalSplitAmount > transaction.Amount)
                throw new BusinessValidationException("Total split amount exceeds transaction amount.", 440);

            // Briši prethodne splitove
            _context.TransactionSplit.RemoveRange(transaction.Splits);

            // Dodaj nove splitove
            var newSplits = splits.Select(s => new TransactionSplit
            {
                TransactionId = transactionId,
                Amount = s.Amount,
                CatCode = s.CatCode
            });

            await _context.TransactionSplit.AddRangeAsync(newSplits);
            await _context.SaveChangesAsync();

            return true;
        }


    }

}
