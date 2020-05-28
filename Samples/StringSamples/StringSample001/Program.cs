using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSample001
{
    // C# 6
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Bill";
            int age = 35;
            // 以前這樣寫
            Console.WriteLine(string.Format("{0} 的年齡是 {1}", name, age));
            //現在可以這樣寫
            Console.WriteLine($"{name} 的年齡是 {age}");
            // 一樣可以格式化字串
            double weight = 62.1;
            Console.WriteLine($"{name} 的體重是 {weight:##.000}");
            Console.WriteLine($"日期時間 {DateTime.Now: yyyy/MM/dd HH:mm:ss}");
            //逐字解譯字串常值, 若版本為 8.0 可以使用 @$
            Console.WriteLine($@"\ABC\DEF");
            int @for = 100;
            Console.WriteLine(@for);

            Console.ReadLine();
          

        }
    }
}
