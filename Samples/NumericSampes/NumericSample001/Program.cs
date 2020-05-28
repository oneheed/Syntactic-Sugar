using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericSample001
{
    // C# 7.0
    class Program
    {
        static void Main(string[] args)
        {
            // 二進位表示
            int four  = 0b0100;   
            Console.WriteLine(four);
            //分隔符號表式
            // 一般習慣是千分位，但不限於
            int million = 1_000_000;
            Console.WriteLine(million);
            int hundred = 1_00;
            Console.WriteLine(hundred);
            // 二進位和十六進位表示式也是可以用分隔符號的
            int eight = 0b1_000;
            int sixteen = 0x1_0;
            Console.WriteLine(eight);
            Console.WriteLine(sixteen);
            Console.ReadLine();
           
        }
    }
}
