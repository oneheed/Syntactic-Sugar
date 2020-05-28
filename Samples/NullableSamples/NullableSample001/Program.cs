using System;
#nullable enable
namespace NullableSample001
{
    // C# 8.0
    class Program
    {
        static void Main(string[] args)
        {            
            string s1 = "ABC";

            //使用 ? 後綴代表此變數可以指派 null 
            string? s2 = null;

            Console.WriteLine($"{s1} {s2}");
            
        }
    }
}
