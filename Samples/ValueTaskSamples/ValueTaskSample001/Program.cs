using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTaskSample001
{
    class Program
    {
        async static Task Main(string[] args)
        {
            await WaitAsync(100);
        }

        async static ValueTask WaitAsync(int ms)
        {
            await Task.Delay(1000);
        }

        async static ValueTask <int> RequestAsync()
        {
            await Task.Delay(1000);
            return 100;
        }
    }
}
