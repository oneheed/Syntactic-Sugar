using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunctionSample002
{

    // C# 8.0
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new List<string>() { "1", "2", "3", "4", "5" };
            var list = list1;
            Display(list);
            var list2 = new List<string>() { "A", "B", "C", "D", "E" };
            list = list2;
            Display(list);
            Console.ReadLine();

            static void Display(IEnumerable<string> list)
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
