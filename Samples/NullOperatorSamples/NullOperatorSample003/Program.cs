using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullOperatorSample003
{
    // C# 6, .NET Framework 4.5
    class Program
    {
        static void Main(string[] args)
        {
            List<MyClass> list = null;
            InternalExecute(list, 0);
            Console.WriteLine("Create List instance");
            list = new List<MyClass> { null, null, null, null };
            InternalLoop(list);
            Console.WriteLine("Add MyClass instance");
            list.Add(new MyClass());
            InternalLoop(list);
            Console.ReadLine(); 

        }

        private static void InternalLoop(List<MyClass> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                InternalExecute(list, i);
            }
        }

        private static void InternalExecute(List<MyClass> list, int i)
        {
            list?[i]?.Execute(i);
        }
    }


    class MyClass
    {
        public void Execute(int index)
        {
            Console.WriteLine($"Another Execute {index}");
        }
    }
}
