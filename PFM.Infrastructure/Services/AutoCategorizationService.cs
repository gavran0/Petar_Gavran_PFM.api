using Microsoft.EntityFrameworkCore;
using Npgsql;
using PFM.Application.Services;
using PFM.Domain.Entities;
using PFM.Infrastructure.Persistence;
using System;
using System.Threading.Tasks;

namespace PFM.Infrastructure.Services
{
    public class AutoCategorizationService : IAutoCategorizationService
    {
        private readonly PFMDbContext _db;
        private readonly IRuleLoaderService _ruleLoader;

        public AutoCategorizationService(PFMDbContext db, IRuleLoaderService ruleLoader)
        {
            _db = db;
            _ruleLoader = ruleLoader;
        }

        public async Task<int> AutoCategorizeAsync()
        {
            var rules = _ruleLoader.LoadRules();
            int totalUpdated = 0;

            foreach (var rule in rules)
            {
                if (string.IsNullOrWhiteSpace(rule.Predicate))
                {
                    Console.WriteLine($"⚠️ Pravilo '{rule.Title}' nema predicate, preskačem.");
                    continue;
                }

                string sql = $@"
                    UPDATE public.""Transactions""
                    SET ""CatCode"" = @cat
                    WHERE ""CatCode"" IS NULL
                      AND ({rule.Predicate})";

                var param = new NpgsqlParameter("@cat", rule.CatCode);
                int affected = await _db.Database.ExecuteSqlRawAsync(sql, param);

                Console.WriteLine($"✅ Pravilo '{rule.Title}' ažuriralo je {affected} redova.");

                totalUpdated += affected;
            }

            return totalUpdated;
        }
    }
}
