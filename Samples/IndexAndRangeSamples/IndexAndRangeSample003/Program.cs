using System;
using System.Collections.Generic;

namespace IndexAndRangeSample003
{
    // C# 8.0 .NET Core 3.0
    class Program
    {
        // 陣列才能使用 Range struct

        private static string[] _array;
        static void Main(string[] args)
        {
            _array = new string[] { "A0", "B1", "C2", "D3", "E4", "F5" };



            var ranges = new List<Range>
            {
                 // 明確呼叫建構式
                 new Range(1, ^2), 
                 // 使用靜態方法
                 Range.StartAt(4),
                 Range.StartAt (^1),
                 Range.EndAt (2),
                 Range.EndAt (^3),
                 // 使用 .. 運算子
                 { ..},
                 {0..^0 },
                 {1..3 },
                 {2.. },
                 { ..^2}
            };

            Display(ranges);
            Show();

            Console.ReadLine();
        }

        static void Display(IEnumerable<Range> ranges)
        {
            foreach (var range in ranges)
            {
                foreach (var item in _array[range])
                {
                    Console.Write($"{item},");
                }
                Console.WriteLine("===================");
            }

        }

        // 也能直接這樣用
        static void Show()
        {
            foreach (var item in _array[2..^2])
            {
                Console.Write($"{item},");
            }
        }
    }
}
