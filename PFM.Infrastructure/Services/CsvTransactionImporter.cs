using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.EntityFrameworkCore;
using PFM.Application.Services;
using PFM.Domain.Entities;
using PFM.Infrastructure.CSV.Maps;
using PFM.Infrastructure.Persistence;
using System.Globalization;

namespace PFM.Infrastructure.Services
{
    public class CsvTransactionImporter : ITransactionImporter
    {
        private readonly PFMDbContext _context;

        // Konstruktor prima DbContext i čuva ga u polju
        public CsvTransactionImporter(PFMDbContext context)
        {
            _context = context;
        }
        public async Task<ImportResult> ImportTransactionsAsync(Stream csvStream)
        {
            var result = new ImportResult();

            if (csvStream == null || csvStream.Length == 0)
            {
                result.Errors.Add("CSV stream is empty.");
                return result;
            }

            try
            {
                using var reader = new StreamReader(csvStream);
                using var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = true,
                    Delimiter = ";",
                    MissingFieldFound = null, // Ne baca exception ako fali polje
                    HeaderValidated = null
                });

                csv.Context.RegisterClassMap<TransactionMap>();
                var transactions = csv.GetRecords<Transactions>().ToList();

                if (transactions.Count == 0)
                {
                    result.Errors.Add("No transactions found in the file.");
                    return result;
                }

                result.ImportedCount = transactions.Count;

                _context.Transactions.AddRange(transactions);
                await _context.SaveChangesAsync();
                // TODO: Ovde dodaj upis u bazu kad povežemo EF Core
            }
            catch (HeaderValidationException hex)
            {
                result.Errors.Add($"CSV header validation failed: {hex.Message}");
            }
            catch (CsvHelperException csvEx)
            {
                result.Errors.Add($"CSV parsing failed: {csvEx.Message}");
            }
            //catch (Exception ex)
            //{
            //    var messages = new List<string>();
            //    Exception currentEx = ex;
            //    while (currentEx != null)
            //    {
            //        messages.Add(currentEx.Message);
            //        currentEx = currentEx.InnerException;
            //    }
            //    var fullMessage = string.Join(" --> ", messages);
            //    result.Errors.Add($"Import failed: {fullMessage}");
            //}

            return result;
        }
    }
}
