using BenchmarkDotNet.Attributes;
using System;

namespace PerformanceTest.PerformanceTests
{
    [HtmlExporter]
    [MemoryDiagnoser]
    public class LocalVsFuncTest
    {
        [Benchmark]
        public void AddFunc()
        {
            Func<int, int, int> addNum = (x, y) => x + y;
            addNum(10, 10);
        }

        [Benchmark]
        public void AddLocal()
        {
            addNum(10, 10);
            int addNum(int x, int y)
            {
                return x + y;
            }
        }

    }
}
