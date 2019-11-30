using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;

namespace PerformanceTest.PerformanceTests
{
    [HtmlExporter]
    [MemoryDiagnoser]
    public class ForEachLoopVsMethodTest
    {
        private readonly List<int> _listOfNumbers;
        private readonly int _size;
        public ForEachLoopVsMethodTest()
        {
            _size = 100;
            _listOfNumbers = new List<int>();
            for (int i = 0; i < _size; i++)
            {
                _listOfNumbers.Add(i);
            }
        }

        [Benchmark]
        public void ForEachMethod()
        {            
            _listOfNumbers.ForEach(x => 
            {
            });
        }

        [Benchmark]
        public void ForEachLoop()
        {           
            foreach (var item in _listOfNumbers)
            {

            }
        }

       
    }
}
