using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkTest.PerformanceTests;
using System;
using System.Threading;

namespace BenchmarkTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<TestWork>();
            Console.Read();
        }
    }    
    [MemoryDiagnoser]
    public class TestWork
    {
        [Benchmark]
        public void Work()
        {
            //Do some work to test.
        }      
    }
}
