using BenchmarkTest.PerformanceTests.Models;
using System.Threading.Tasks;


namespace BenchmarkTest
{
    public class TestIL
    {
        public void TestVar()
        {
            var student = new Student();            
        }
        public void TestType()
        {
            Student student = new Student();                        
        }
        
        public async Task TestAsync1()
        {
            await TestAsync2();
        }

        public async Task TestAsync2()
        {
            await System.IO.File.ReadAllTextAsync(@"D:\temp\TestLogs.log");
        }
        
        public async Task TestTask1()
        {
            await TestTask2();
        }

        public Task TestTask2()
        {
            return System.IO.File.ReadAllTextAsync(@"D:\temp\TestLogs.log");
        }
    }
}
