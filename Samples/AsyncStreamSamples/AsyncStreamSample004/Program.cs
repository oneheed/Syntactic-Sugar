using System;
using System.Threading.Tasks;

namespace AsyncStreamSample004
{
    // C# 8.0, .NET Core 3.0

    /// <summary>
    /// Async Stream, 完整實作
    /// </summary>
    class Program
    {
        private static string path = "SourceFile.txt";
        async static Task Main(string[] args)
        {
            //await foreach (var line in new EnumerableText(path))
            //{
            //    Console.WriteLine(line);
            //}

            var enumertor = (new EnumerableText(path)).GetAsyncEnumerator();
            while (await enumertor.MoveNextAsync ()  )
            {
                Console.WriteLine(enumertor.Current);
            }

            Console.ReadLine();
        }

    }
}
