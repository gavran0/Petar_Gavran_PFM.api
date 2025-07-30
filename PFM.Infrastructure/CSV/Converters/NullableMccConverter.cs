using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using PFM.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFM.Infrastructure.CSV.Converters
{
    public class NullableMccConverter : DefaultTypeConverter
    {
        public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
        {
            if (string.IsNullOrWhiteSpace(text))
                return null;

            if (int.TryParse(text, out int code))
            {
                if (Enum.IsDefined(typeof(MccCode), code))
                    return (MccCode)code;
            }

            return null;
        }
    }
}
