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
    public class CsvCategoryImporter : ICategoryImporter
    {
        private readonly PFMDbContext _context;

        public CsvCategoryImporter(PFMDbContext context)
        {
            _context = context;
        }

        public async Task<ImportResult> ImportCategoriesAsync(Stream csvStream)
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
                    Delimiter = ",",
                    MissingFieldFound = null,
                    HeaderValidated = null
                });

                csv.Context.RegisterClassMap<CategoryMap>();

                var categories = csv.GetRecords<Category>().ToList();

                if (categories.Count == 0)
                {
                    result.Errors.Add("No categories found in the file.");
                    return result;
                }

                //_context.Categories.AddRange(categories);

                foreach (var cat in categories)
                {
                    var existing = await _context.Categories.FindAsync(cat.Code);
                    if (existing != null)
                    {
                        existing.Name = cat.Name;
                        existing.ParentCode = null; // postavi null dok ne ažuriramo
                    }
                    else
                    {
                        _context.Categories.Add(new Category
                        {
                            Code = cat.Code,
                            Name = cat.Name,
                            ParentCode = null // privremeno null
                        });
                    }
                }

                await _context.SaveChangesAsync();

                // 2. Ažuriraj ParentCode za sve koji ga imaju
                foreach (var cat in categories.Where(c => !string.IsNullOrEmpty(c.ParentCode)))
                {
                    var entity = await _context.Categories.FindAsync(cat.Code);
                    if (entity != null)
                    {
                        var parentExists = await _context.Categories.AnyAsync(c => c.Code == cat.ParentCode);
                        if (parentExists)
                        {
                            entity.ParentCode = cat.ParentCode;
                        }
                        else
                        {
                            result.Errors.Add($"Parent category '{cat.ParentCode}' not found for '{cat.Code}'");
                        }
                    }
                }

                await _context.SaveChangesAsync();

                result.ImportedCount = categories.Count;
            }
            catch (HeaderValidationException hex)
            {
                result.Errors.Add($"CSV header validation failed: {hex.Message}");
            }
            catch (CsvHelperException csvEx)
            {
                result.Errors.Add($"CSV parsing failed: {csvEx.Message}");
            }
            // Ako hoćeš i generalni exception, otkomentariši ovo:
            /*
            catch (Exception ex)
            {
                var messages = new List<string>();
                Exception currentEx = ex;
                while (currentEx != null)
                {
                    messages.Add(currentEx.Message);
                    currentEx = currentEx.InnerException;
                }
                var fullMessage = string.Join(" --> ", messages);
                result.Errors.Add($"Import failed: {fullMessage}");
            }
            */

            return result;
        }
    }
}
