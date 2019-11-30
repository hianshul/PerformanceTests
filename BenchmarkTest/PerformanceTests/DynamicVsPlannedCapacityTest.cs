using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace BenchmarkTest.PerformanceTests
{
    [HtmlExporter]
    [MemoryDiagnoser]
    public class DynamicVsPlannedCapacityTest
    {
        private readonly int _size = 100000;

        [Benchmark]
        public void ListDynamicCapacity()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < _size; i++)
            {
                list.Add(i);
            }
        }


        [Benchmark]
        public void ListPlannedCapacity()
        {
            List<int> list = new List<int>(1000);
            for (int i = 0; i < _size; i++)
            {
                list.Add(i);
            }
        }
    }
}
