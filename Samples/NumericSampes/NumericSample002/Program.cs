using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericSample002
{
    // C# 7.2
    class Program
    {
        static void Main(string[] args)
        {
            // 可使用底線分隔 進位符號與數字            
            int four = 0b_0100;
            Console.WriteLine(four);        
            int eight = 0b_1_000;
            int sixteen = 0x_10;
            Console.WriteLine(eight);
            Console.WriteLine(sixteen);
            Console.ReadLine();
        }
    }
}
