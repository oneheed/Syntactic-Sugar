using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTupleSample005
{
    // C#7.1
    class Program
    {
        static void Main(string[] args)
        {

           
            int count = 15;
            string label = "Bill Chung";
            // C# 7.0
            var pair1 = (count: count, label: label);
            // C# 7.1
            var pair2 = (count, label);

            Console.WriteLine(pair1.count);
            Console.WriteLine(pair2.label);

            Console.ReadLine();
        }
    }
}
