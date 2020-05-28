using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncStreamSample002
{
    // C# 7.3

    /// <summary>
    /// 硬幹非同步資料流
    /// </summary>
    class Program
    {
        private static string path = "SourceFile.txt";
        async static Task Main(string[] args)
        {
            foreach (var task in ReadLineAsync())
            {
                Console.WriteLine(await task);
            }

            Console.ReadLine();
        }

        static IEnumerable<Task<string>> ReadLineAsync()
        {
            using (StreamReader reader = File.OpenText(path))
            {
                //var enumerator = new MyEnumerator(reader);
                //while (enumerator.MoveNext())
                //{
                //    yield return enumerator.Current;
                //}

                while (reader.ReadLineAsync().GetAwaiter().GetResult() is string line)
                {
                    Task.Delay(100).Wait();
                    yield return Task.FromResult(line);
                }
            }
        }


    }


    class MyEnumerator : IEnumerator<Task<string>>

    {
        private StreamReader _reader;
        public MyEnumerator(StreamReader reader)
        {
            _reader = reader;
        }
        public Task<string> Current { get; private set; }

        object IEnumerator.Current => Current;

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            Task.Delay(100).GetAwaiter().GetResult();
            var result = _reader.ReadLine();
            Current = Task.FromResult(result);
            return result != null;
        }

        public void Reset()
        {
            _reader.BaseStream.Seek(0, SeekOrigin.Begin);
        }
    }
}
