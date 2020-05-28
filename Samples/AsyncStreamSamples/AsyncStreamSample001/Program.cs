using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncStreamSample001
{
    // C# 7.3 
    /// <summary>
    /// 沒有 async stream 的時候
    /// </summary>
    class Program
    {
        private static string path = "SourceFile.txt";
        async static Task Main(string[] args)
        {
            foreach (var line in await ReadLinesAsync())
            {
                Console.WriteLine(line);
            }

            Console.ReadLine();
        }

        static async Task<IEnumerable<string>> ReadLinesAsync()
        {
            using (StreamReader reader = File.OpenText(path))
            {
                var result = new List<string>();

                // 用了 pattern matching 好方便
                while (await reader.ReadLineAsync() is string line)
                {
                    // 製造效果,需要 delay
                    await Task.Delay(100);
                    result.Add(line);
                }

                return result;

            }
        }
    }
}
