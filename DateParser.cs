using System;

namespace BenchmarkExample
{
    public class DateParser
    {
        internal int GetYearFromDateTime(string dateTimeAsString)
        {
            var dateTime = DateTime.Parse(dateTimeAsString);
            return dateTime.Year;
        }

        internal int GetYearFromDateTimeSplit(string dateTimeAsString)
        {
            var splitOnHyphen = dateTimeAsString.Split("-");
            return int.Parse(splitOnHyphen[0]);
        }

        internal int GetYearFromDateTimeSpan(ReadOnlySpan<char> dateTimeAsSpan)
        {
            var indexOnHyphen = dateTimeAsSpan.IndexOf("-");
            return int.Parse(dateTimeAsSpan.Slice(0, indexOnHyphen));
        }

        internal int GetYearFromDateTimeSpanWithManualConversion(ReadOnlySpan<char> dateTimeAsSpan)
        {
            var indexOnHyphen = dateTimeAsSpan.IndexOf("-");
            var yearAsSpan = dateTimeAsSpan.Slice(0, indexOnHyphen);

            int temp = 0;
            for (int i = 0; i < yearAsSpan.Length; i++)
            {
                temp = temp * 10 + (yearAsSpan[i] - '0');
            }

            return temp;
        }
    }
}