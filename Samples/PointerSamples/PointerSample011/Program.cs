using System;

namespace PointerSample011
{
    // C# 8.0 (這個範例前半部和編譯器版本關係不大, 會用到 8 主要是因為 .. 和 ^ 運算子) 
    // .NET Core 3.0 for Index & Range
    class Program
    {
        static void Main(string[] args)
        {
            var bytes = new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            // 以下 .NET Core 2.1 即可
            var span1 = bytes.AsSpan();
            Display(span1);
            var span2 = bytes.AsSpan(3);
            Display(span2);
            var span3 = bytes.AsSpan(6, 2);
            Display(span3);
            span3[0] = 99;
            Display(span1);
            

            // 以下要 .NET Core 3.0
            var span4 = bytes.AsSpan(^2);
            Display(span4);
            var span5 = bytes.AsSpan(1..^1);
            Display(span5);

            Console.WriteLine();

        }

        static void Display(Span<byte> source)
        {
            foreach (var item in source)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------");
        }
    }
}
