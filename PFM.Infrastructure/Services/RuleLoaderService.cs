using Microsoft.Extensions.Configuration;
using PFM.Application.Services;
using PFM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using YamlDotNet.Serialization;

namespace PFM.Infrastructure.Services
{
    public class RuleLoaderService : IRuleLoaderService
    {
        private readonly string _filePath;

        public RuleLoaderService(IConfiguration configuration)
        {
            // Ova putanja očekuje da u folderu Config u izlaznom folderu postoji YAML fajl
            _filePath = Path.Combine(AppContext.BaseDirectory, "Config", "category-rules.yml");
        }

        public List<CategorizationRule> LoadRules()
        {
            if (!File.Exists(_filePath))
            {
                Console.WriteLine($"⚠️ YAML fajl nije pronađen: {_filePath}");
                return new List<CategorizationRule>();
            }

            var yaml = File.ReadAllText(_filePath);

            var deserializer = new DeserializerBuilder()
                .IgnoreUnmatchedProperties()
                .Build();

            var rules = deserializer.Deserialize<List<CategorizationRule>>(yaml);

            Console.WriteLine($"✅ Učitano pravila: {rules?.Count ?? 0}");

            return rules ?? new List<CategorizationRule>();
        }

    }
}
