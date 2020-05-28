using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using static
using static System.String;
using static System.Math;
using static System.Console;

namespace UsingStaticSample001
{
    // C# 6, .NET Frameowrk 4.5
    class Program
    {
        static void Main(string[] args)
        {
            var s = Empty;
            WriteLine(String.Compare(s, String.Empty));
            WriteLine($"圓周率是 {PI}");
            WriteLine($"2 的 3 次方是 {Pow(2, 3)}");          
            ReadLine();
           
        }
    }
}
