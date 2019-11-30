using BenchmarkDotNet.Running;
using PerformanceTest.PerformanceTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<StringBuilderTest>();
            Console.Read();
        }
    }
}
