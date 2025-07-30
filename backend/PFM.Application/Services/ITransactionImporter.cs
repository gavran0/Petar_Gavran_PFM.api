using System;
using PFM.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFM.Application.Services
{
    public interface ITransactionImporter
    {
        Task<ImportResult> ImportTransactionsAsync(Stream csvStream);
    }
}
