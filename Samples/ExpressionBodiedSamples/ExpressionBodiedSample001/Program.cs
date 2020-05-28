using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionBodiedSample001
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(GetName());
            var v1 = Parse("123");
            var v2 = Parse("abc");
            Display(v1);
            Display(v2);

            Console.ReadLine();
        }

        private static string GetName() => "Bill";

        // 不能寫成這樣，除非你要回傳 0 ，但是這樣回傳 int 就好啦(default 會出包的狀況之一)
        // private static int? Parse(string s) => int.TryParse(s, out int v) ? v : default;

        // 要寫成這樣
        //private static int? Parse(string s) => int.TryParse(s, out int v) ? new int?(v) : default;
        // 或是這樣
        private static int? Parse(string s) => int.TryParse(s, out int v) ? v : default(int?);

        private static void Display(int? v)
        {
            if (v.HasValue)
            {
                Console.WriteLine(v.Value);
            }
            else
            {
                Console.WriteLine("v is null");
            }
        }

    }
}
