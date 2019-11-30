using BenchmarkDotNet.Attributes;
using PerformanceTest.PerformanceTests.Models;

namespace PerformanceTest.PerformanceTests
{
    [HtmlExporter]
    [MemoryDiagnoser]
    public class PatternMatch
    {
        private object _obj;
        public PatternMatch()
        {
            _obj = new Student() {FirstName="Anshul" };
        }
        [Benchmark]
        public void PatternMatchIFIs()
        {
            if(_obj is Student s)
            {
                string firstName = s.FirstName;
            }
        }
        [Benchmark]
        public void PatternMatchIsAs()
        {
            if (_obj is Student)
            {
                var s = _obj as Student;
                string firstName = s.FirstName;
            }
        }


    }

}
