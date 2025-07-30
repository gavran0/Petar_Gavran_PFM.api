using CsvHelper.Configuration;
using PFM.Domain.Entities;

namespace PFM.Infrastructure.CSV.Maps
{
    public sealed class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Map(m => m.Code).Name("code");
            Map(m => m.Name).Name("name");
            Map(m => m.ParentCode).Name("parent-code").Optional();
        }
    }
}
