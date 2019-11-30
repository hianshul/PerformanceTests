using BenchmarkDotNet.Attributes;
using System.Threading.Tasks;

namespace PerformanceTest.PerformanceTests
{
    [HtmlExporter]
    [MemoryDiagnoser]
    public class AsyncTests
    {
        public string TestTask()
        {
            return System.IO.File.ReadAllText(@"D:\temp\TestLogs.log");
        }
        public string  TestAsync()
        {
            return System.IO.File.ReadAllText(@"D:\temp\TestLogs.log");
        }

        [Benchmark]
        public async Task Test_AsyncTask()
        {
            await TestAsync();
        }
        [Benchmark]
        public async Task Test_Task()
        {
            await TestTask();
        }
    }
}
