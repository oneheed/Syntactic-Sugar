using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingSample001_2
{

    /// <summary>
    /// Type Pattern Matching 關於 null 注意事項
    /// 使用 var 就不判別是否為 null
    /// C# 8.0 後可以使用 {}
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IsNullTest(null);
            Console.WriteLine("=======================");
            IsNullTest(new object());
          
            Console.ReadLine();
        }

        static void IsNullTest(object o)
        {
            if (o is object)
            {
                Console.WriteLine("進入 o is object");
            }

            if (o is object x)
            {
                Console.WriteLine("進入 o is object x");
            }

            if (o is var y)
            {
                Console.WriteLine("進入 o is var y");
            }

            // C# 8.0 後可以用 {}, 進一步的用法在 propaerty pattern matching
            if (o is {})
            {
                Console.WriteLine("進入 o is {}");
            }

            if (o is {} z)
            {
                Console.WriteLine("進入 o is {} z");
            }
        }
    }
}
