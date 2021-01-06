using BenchmarkDotNet.Order;
using BenchmarkDotNet.Attributes;

namespace BenchmarkExample
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class DateParserBenchmarks
    {
        private const string dateTime = "2020-12-11T12:15:59Z";
        private static readonly DateParser parser = new DateParser();

        [Benchmark]
        public void GetYearFromDateTime()
        {
            parser.GetYearFromDateTime(dateTime);
        }
        
        [Benchmark]
        public void GetYearFromDateTimeSplit()
        {
            parser.GetYearFromDateTimeSplit(dateTime);
        }        

        [Benchmark]
        public void GetYearFromDateTimeSpan()
        {
            parser.GetYearFromDateTimeSpan(dateTime);
        }
        
        [Benchmark]
        public void GetYearFromDateTimeSpanWithManualConversion()
        {
            parser.GetYearFromDateTimeSpanWithManualConversion(dateTime);
        }
        
    }
}