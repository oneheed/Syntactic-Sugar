using System;

namespace PointerSample013
{
    // C# 7.2
    class Program
    {
        static void Main(string[] args)
        {
            string s = "This is a book!";
            var span1 = s.AsSpan();
            Console.WriteLine(span1.ToString());
            var span2 = s.AsSpan(5);
            Console.WriteLine(span2.ToString());
            var span3 = s.AsSpan(10, 4);
            Console.WriteLine(span3.ToString());        
            Console.ReadLine();
        }
    }
}
