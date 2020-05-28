using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingScopeSample001
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lines = new List<string>
            {
                "AAA","ABBB","CCCCC","FFFF"
            };
            Save(lines);
            Console.WriteLine("========= Main Completed!");

        }

        static void Save(IEnumerable<string> lines)
        {
            //using (var file = new System.IO.StreamWriter("file1.txt"))
            //{
            //    foreach (string line in lines)
            //    {
            //        if (!line.Contains("Second"))
            //        {
            //            file.WriteLine(line);
            //        }
            //    }

            //    file.Close();
            //    Console.WriteLine("End");
            //}



            using var file = new System.IO.StreamWriter("file1.txt");


            foreach (string line in lines)
            {
                if (!line.Contains("Second"))
                {
                    file.WriteLine(line);
                }
            }
            file.Close();


            Console.WriteLine("End");



            // 在方法結束前將會呼叫 file.Dispose();
        }
    }
}
