using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    public class Class1
    {
        public async Task Test1()
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            await wc.OpenReadTaskAsync(new Uri("http://www.google.com"));
        }



    }
}
