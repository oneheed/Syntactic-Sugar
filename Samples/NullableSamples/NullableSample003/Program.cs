using NullableSample003Library;
using System;

namespace NullableSample003
{
    // C# 8.0
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = null;
            MyClass.NullableTest(s1);
            Console.ReadLine();
        }
    }
}
