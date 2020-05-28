using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointerSample008
{
    // C# 7.3
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1, 2, 3, 4, 5 };
            ref var result = ref array[0];
            result = 99;
            Console.WriteLine(array[0]);

            // 重新指派 ref 區域變數
            result = ref array[1];
            Console.WriteLine(result);
            result = 888;
            Console.WriteLine(array[1]);

            Console.ReadLine();           

        }
    }
}
