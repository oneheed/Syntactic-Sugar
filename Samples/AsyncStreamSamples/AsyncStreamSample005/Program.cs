using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncStreamSample005
{
    // C# 8.0, .NET Frameowrk 4.7.2

    /// <summary>
    /// 傳統 .NET Frameowrk 使用 Async Stream
    /// </summary>
    class Program
    {
        private static string path = "SourceFile.txt";
        async static Task Main(string[] args)
        {
            await foreach (var line in new EnumerableText(path))
            {
                Console.WriteLine(line);
            }

            Console.ReadLine();
        }
    }
}
