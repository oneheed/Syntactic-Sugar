using System;
using System.Collections.Generic;

namespace IndexAndRangeSample001
{

    // C# 8.0 .NET Core 3.0
    class Program
    {
        // 陣列或集合都可以使用 Index struct

        private static List<string> _array;
        /// <summary>
        /// 建立 Index 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // 從前面是 0 開始， 倒數則是倒數第一個，是由 1 開始

            _array = new  List<string> { "A0", "B1", "C2", "D3", "E4", "F5" };

            // 明確呼叫建構式
            Index index1 = new Index(1, false);          
            Index index2 = new Index(1, true);


            // 使用隱性轉換
            Index index3 = 2;
            Index index4 = ^2;

            // 使用靜態方法            
            Index index5 = Index.FromEnd(1);
            Index index6 = Index.FromStart(1);

            // 靜態屬性
            Index index7 = Index.Start;
            Index index8 = Index.End; // ^0

            Console.WriteLine(GetString(index1));
            Console.WriteLine(GetString(index2));
            Console.WriteLine(GetString(index3));
            Console.WriteLine(GetString(index4));
            Console.WriteLine(GetString(index5));
            Console.WriteLine(GetString(index6));
            Console.WriteLine(GetString(index7));
            // Console.WriteLine(GetString(index8)); // 超出範圍

            Console.ReadLine();
        }

        static string GetString(Index index)
        {
            return _array[index];
        }
    }
}
