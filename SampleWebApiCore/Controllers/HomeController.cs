using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SampleWebApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly string _connectionString;
        public HomeController()
        {
            _connectionString = "server=.;uid=sa;pwd=Tpg@123";
        }

        [HttpGet("sync")]
        public IActionResult SyncGet()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var cmd = new SqlCommand("WAITFOR DELAY '00:00:02';", connection);
                cmd.ExecuteNonQuery();
            }

            return Ok(GetThreadInfo());
        }

        [HttpGet("async")]
        public async Task<IActionResult> AsyncGet()
        {            
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var cmd = new SqlCommand("WAITFOR DELAY '00:00:02';",connection);
                await cmd.ExecuteNonQueryAsync();
            }
            return Ok(GetThreadInfo());
        }

        private dynamic GetThreadInfo()
        {
            int availableWorkerThreads;
            int availableAsyncIOThreads;
            ThreadPool.GetAvailableThreads(out availableWorkerThreads, out availableAsyncIOThreads);

            return new { AvailableAsyncIOThreads = availableAsyncIOThreads, AvailableWorkerThreads = availableWorkerThreads };
        }

        //public Task test1()
        //{
        //    Task.Factory.StartNew(() =>
        //    {
        //        Console.WriteLine("test11");
        //    });
        //}
    }
}
