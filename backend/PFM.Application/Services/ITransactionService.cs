using PFM.Application.Models;
using PFM.Application.DTO;
using PFM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFM.Application.Services
{
    public interface ITransactionService
    {
        Task<PagedResult<TransactionDto>> GetTransactionsAsync(
            DateTime? startDate,
            DateTime? endDate,
            string? kind,
            int page,
            int pageSize);

        Task<bool> CategorizeTransactionAsync(string transactionId, string categoryCode);

        Task<bool> SplitTransactionAsync(string transactionId, List<TransactionSplitDto> splits);
    }

}
