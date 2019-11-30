using BenchmarkTest.PerformanceTests.Models;
using System;
using System.Threading;
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
        
        public async Task ControllerMethod1()
        {
            await ServiceMethod1();
        }
        public async Task ServiceMethod1()
        {
            await System.IO.File.ReadAllTextAsync(@"D:\temp\TestLogs.log");
        }        
        public async Task ControllerMethod2()
        {
            await ServiceMethod2();
        }
        public Task ServiceMethod2()
        {
            return System.IO.File.ReadAllTextAsync(@"D:\temp\TestLogs.log");
        }

        public Task<int> Calculate()
        {
            return Task.Run(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine(100);
                return 100;
            });
        }

        public int ReturnValue { get; set; }
        public void CalculateTask()
        {            
            var calculationTask = Calculate();
            calculationTask.ContinueWith(t => {
                
                Console.WriteLine(t.Result);
                ReturnValue = t.Result;
                Console.WriteLine(ReturnValue);

            },
                TaskScheduler.FromCurrentSynchronizationContext());

        }

        public async Task<int> CalculateTaskAsync()
        {
            return await Calculate();
    

            //calculationTask.ContinueWith(t => Console.WriteLine(t.Result),
            //    TaskScheduler.FromCurrentSynchronizationContext());
        }


    }

    public class CalculateAsyncAwait
    {
        public Task<int> Calculate()
        {
            return Task.Run(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine(100);
                return 100;
            });
        }

        public int ReturnValue { get; set; }
       
        public async Task<int> CalculateTaskAsync()
        {
            return await Calculate();


            //calculationTask.ContinueWith(t => Console.WriteLine(t.Result),
            //    TaskScheduler.FromCurrentSynchronizationContext());
        }
    }

    public class CalculateTasks
    {
        public Task<int> Calculate()
        {
            return Task.Run(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine(100);
                return 100;
            });
        }

        public int ReturnValue { get; set; }
        public void CalculateTask()
        {
            var calculationTask = Calculate();
            calculationTask.ContinueWith(t =>
            {

                Console.WriteLine(t.Result);
                ReturnValue = t.Result;
                Console.WriteLine(ReturnValue);

            },
                TaskScheduler.FromCurrentSynchronizationContext());
        
        }
    }
}
