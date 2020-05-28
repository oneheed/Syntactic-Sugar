using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace AsyncStreamSample003
{
    // C# 8.0, .NET Core 3.0

    /// <summary>
    /// Async Stream,  使用 yield return 語法糖
    /// </summary>
    class Program
    {
        private static string path = "SourceFile.txt";
        async static Task Main(string[] args)
        {
            await foreach (var line in ReadLineAsync())
            {
                Console.WriteLine(line);
            }

            Console.ReadLine();
        }

        async static IAsyncEnumerable<string> ReadLineAsync()
        {
            using (StreamReader reader = File.OpenText(path))
            {
                while (await reader.ReadLineAsync() is string line)
                {
                    await Task.Delay(100);
                    yield return line;
                }
            }

        }
    }
}
