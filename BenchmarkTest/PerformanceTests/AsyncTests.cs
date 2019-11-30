using BenchmarkDotNet.Attributes;
using System.Threading.Tasks;

namespace BenchmarkTest.PerformanceTests
{
    [HtmlExporter]
    [MemoryDiagnoser]
    public class AsyncTests
    {
        public async Task<string> TestTask()
        {
            return await System.IO.File.ReadAllTextAsync(@"D:\temp\TestLogs.log");
        }
        public async Task<string> TestAsync()
        {
            return await System.IO.File.ReadAllTextAsync(@"D:\temp\TestLogs.log");
        }

        [Benchmark]
        public async Task Test_AsyncTask()
        {
            await TestAsync();
        }
        [Benchmark]
        public async Task Test_Task()
        {
            int i = 1 + 2;
            await TestTask();
        }

        [Benchmark]
        public async Task AsyncOperation()
        {
            int i = 1 + 2;
            await TestTask();
        }
        [Benchmark]
        public async Task TestAsyncOperation1()
        {
            await Task.Run(() =>
            {
                int i = 1 + 2;
            });
            await TestTask();
        }


    }
}
