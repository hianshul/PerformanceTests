using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkTest.PerformanceTests
{
    [HtmlExporter]
    [MemoryDiagnoser]
    public class NestedAsyncTest
    {
        [Benchmark]
        public async Task Async1()
        {
            await Async2();
        }
        public async Task Async2()
        {
            await Async3();
        }
        public async Task Async3()
        {
            await Async4();
        }
        public async Task Async4()
        {
            await Async5();
        }
        public async Task Async5()
        {
            await Async6();
        }
        public async Task Async6()
        {
            await Task.Factory.StartNew(() =>
            {
                int i = 1 + 1;                
            });
        }
        [Benchmark]
        public async Task AsyncTask1()
        {
            await AsyncTask3();
        }
        public Task AsyncTask2()
        {
            return AsyncTask3();
        }
        public Task AsyncTask3()
        {
            return AsyncTask4();
        }
        public Task AsyncTask4()
        {
            return AsyncTask5();
        }
        public Task AsyncTask5()
        {
            return AsyncTask6();
        }
        public Task AsyncTask6()
        {
            return Task.Factory.StartNew(() =>
            {
                int i = 1 + 1;
            });
        }



        public async Task F1()
        {
            await AsyncTask5();
        }
        public async Task F2()
        {
            await AsyncTask5();
        }

        public async Task F3()
        {
            
            await F1();
            await F2();

        }

        public int F9()
        {
            for (int i = 0; i < 1000; i++)
            {

            }
            return 0;
        }


        public async Task F4()
        {
            await F3();
        }
    }
}
