using System;
using System.Collections.Generic;

namespace IndexAndRangeSample002
{
    // C# 8.0 .NET Core 3.0
    class Program
    {       /// <summary>
            /// IsFromEnd, Value & GetOffset
            /// </summary>
            /// <param name="args"></param>
        static void Main(string[] args)
        {
            Index index1 = 2;
            DisplayInfo(index1, nameof(index1));
            Index index2 = ^2;
            DisplayInfo(index2, nameof(index2));


            Console.WriteLine($"Offset : {index2.GetOffset(10)}");
            Console.WriteLine($"Offset : {index2.GetOffset(1)}");
            Console.ReadLine();
        }

        private static void DisplayInfo(Index index, string name)
        {
            Console.WriteLine($" {name}  : Is From End -- {index.IsFromEnd}, Value -- {index.Value} ");
        }


    }


}
