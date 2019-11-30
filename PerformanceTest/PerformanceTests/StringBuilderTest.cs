using BenchmarkDotNet.Attributes;
using System.Text;

namespace PerformanceTest.PerformanceTests
{
    [HtmlExporter]
    [MemoryDiagnoser]
    public class StringBuilderTest
    {
        // These are randomly assigned at runtime and have about 10 chars each
        private static string _testData1 ="TestData1";
        private static string _testData2 ="TestData2";
        private static string _testData3 ="TestData3";
        private static string _testData4 = "TestData4";
        private static string _testData5 = "TestData5";
        private static string _testData6 = "TestData6";
        private static string _testData7 = "TestData7";
        private static string _testData8 = "TestData8";
        private static string _result;

        [Benchmark]
        public void StringConcat4()
        {
            _result = _testData1 + _testData2 + _testData3 + _testData4+ _testData5 + _testData6 + _testData7 + _testData8;
        }

        [Benchmark]
        public void StringBuilder4()
        {
            StringBuilder sb = new StringBuilder(_testData1);
            sb.Append(_testData2);
            sb.Append(_testData3);
            sb.Append(_testData4);
            sb.Append(_testData5);
            sb.Append(_testData6);
            sb.Append(_testData7);
            sb.Append(_testData8);
            _result = sb.ToString();
        }
        [Benchmark]
        public void StringFormat4()            
        {
            _result = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}", _testData1, _testData2, _testData3, _testData4, _testData5, _testData6, _testData7, _testData8);
        }
        [Benchmark]
        public void StringInterpolation4()
        {
            _result = $"{_testData1}{_testData2}{_testData3}{_testData4}{_testData5}{_testData6}{_testData7}{_testData8}";
        }
    }
}
