using System;
using System.Collections.Generic;

namespace IndexAndRangeSample004
{
    class Program
    {
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
          

            Console.ReadLine();
        }

        private static void Display(IEnumerable<Range> ranges)
        {
            foreach (var range in ranges)
            {
                var info = range.GetOffsetAndLength(_array.Length);
                Console.WriteLine($"Offset : {info.Offset}, Length = {info.Length }");

                var ( offset, length ) = range.GetOffsetAndLength(_array.Length);
                Console.WriteLine($"Offset : {offset}, Length = {length}");

            }
        }
    }
}
