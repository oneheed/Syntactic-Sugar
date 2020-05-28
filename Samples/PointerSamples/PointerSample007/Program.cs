using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointerSample007
{

    // C# 7.2
    class Program
    {
        private static int original = 0;

        static void Main(string[] args)
        {

            int[] array = null;
            ref var result = ref Request(array);
            Console.WriteLine(result);
            result = 99;
            Console.WriteLine(original);           
            Console.ReadLine();
        }

        static ref int Request(int[] array)
        {
            ref var result = ref (array != null ? ref array[0] : ref original);
            return ref result;
        }
    }
}
