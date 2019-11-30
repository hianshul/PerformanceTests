using BenchmarkDotNet.Attributes;
using System;

namespace BenchmarkTest.PerformanceTests
{
    [HtmlExporter]
    [MemoryDiagnoser]
    public class StackAllocTest
    {
        
        [Benchmark]
        public void ArrayWithStackAlloc100()
        {
            int length = 100;
            Span<int> numbers = stackalloc int[length];
            for (var i = 0; i < length; i++)
            {
                numbers[i] = i;
            }
        }


        [Benchmark]
        public void ArrayWithNew100()
        {
            int length = 100;
            var numbers = new int[length];
            for (var i = 0; i < length; i++)
            {
                numbers[i] = i;
            }
        }

        [Benchmark]
        public void ArrayWithStackAlloc10()
        {
            int length = 10;
            Span<int> numbers = stackalloc int[length];
            for (var i = 0; i < length; i++)
            {
                numbers[i] = i;
            }
        }


        [Benchmark]
        public void ArrayWithNew10()
        {
            int length = 10;
            var numbers = new int[length];
            for (var i = 0; i < length; i++)
            {
                numbers[i] = i;
            }
        }
    }
}
