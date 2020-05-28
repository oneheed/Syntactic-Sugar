using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSample002
{
    // C# 6
    class Program
    {
        // 對齊, alignment
        static void Main(string[] args)
        {
           
            Console.WriteLine(string.Format("{0,20} - 圓周率", Math.PI));
            Console.WriteLine($"{Math.PI,20} - 圓周率");
            Console.WriteLine(string.Format("|{0,-10}|{1,10}|", "靠左對齊", "靠右對齊"));
            Console.WriteLine($"|{"靠左對齊",-10}|{"靠右對齊",10}|");
            Console.ReadLine();
        }
    }
}
