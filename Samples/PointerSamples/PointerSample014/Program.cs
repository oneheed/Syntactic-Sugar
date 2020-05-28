using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
namespace PointerSample014
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeat = 10_000_000;
            string fullName = "William Henry Gates";
            Console.WriteLine(SplitLastName(fullName));
            Console.WriteLine(SubstringLastName(fullName));
            Console.WriteLine(SpanSliceLastName(fullName));

            Stopwatch watch = new Stopwatch();
            watch.Start();
            for(int i = 0; i < repeat; i++)
            {
                SplitLastName(fullName);
            }
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);

            watch.Reset();
            watch.Start();
            for (int i = 0; i < repeat; i++)
            {
                SubstringLastName(fullName);
            }
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);

            watch.Reset();
            watch.Start();
            for (int i = 0; i < repeat; i++)
            {
                SpanSliceLastName(fullName);
            }
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);

            Console.ReadLine();

        }

        static string SplitLastName(string fullName)
        {
            var result = fullName.Split(new char[] { ' ' });
            return result[result.Length - 1];
        }

        static string SubstringLastName(string fullName)
        {
            var index = fullName.LastIndexOf(" ", StringComparison.Ordinal);
            return index == -1 ? string.Empty  : fullName.Substring(index + 1);
        }

        static string SpanSliceLastName(string fullName)
        {
            var span = fullName.AsSpan();
            var index = span.LastIndexOf(' ');           
            return index == -1 ? string.Empty : span.Slice(index+1).ToString();

        }
       
    }

}
