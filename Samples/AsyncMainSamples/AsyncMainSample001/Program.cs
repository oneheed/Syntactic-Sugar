using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncMainSample001
{
    class Program
    {
        async static Task Main(string[] args)
        {
            await Task.Delay(1000);
        }
    }
}
