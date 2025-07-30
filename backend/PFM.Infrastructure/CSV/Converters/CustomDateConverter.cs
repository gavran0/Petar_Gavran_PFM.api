using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using System;
using System.Globalization;

public class CustomDateConverter : DefaultTypeConverter
{
    public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
    {
        if (DateTime.TryParseExact(text, "M/d/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var date))
        {
            return DateTime.SpecifyKind(date, DateTimeKind.Utc);
        }

        throw new TypeConverterException(this, memberMapData, text, row.Context, "Invalid date format");
    }
}
