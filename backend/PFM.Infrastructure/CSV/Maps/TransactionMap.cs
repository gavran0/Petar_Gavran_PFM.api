using CsvHelper.Configuration;
using PFM.Domain.Entities;
using PFM.Infrastructure.CSV.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFM.Infrastructure.CSV.Maps
{
    public sealed class TransactionMap : ClassMap<Transactions>

    {
        public TransactionMap()
        {
            Map(m => m.Id).Name("id");
            Map(m => m.BeneficiaryName).Name("beneficiary-name");
            Map(m => m.Date).Name("date").TypeConverter<CustomDateConverter>();
            Map(m => m.Direction).Name("direction");
            Map(m => m.Amount).Name("amount");
            Map(m => m.Description).Name("description");
            Map(m => m.Currency).Name("currency");
            Map(m => m.Mcc).Name("mcc").TypeConverter<NullableMccConverter>();
            Map(m => m.Kind).Name("kind");
        }
    }
}
