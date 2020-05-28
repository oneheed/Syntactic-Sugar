using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullOperatorSample002
{
    // C# 6, .NET Framework 4.5

    /// <summary>
    /// null 條件運算子用在屬性與方法
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = null;
            InternalExecute(obj);
            Console.WriteLine("Create MyClass instance");
            obj = new MyClass();
            InternalExecute(obj);
            Console.WriteLine("Create AnotherClass instance");
            obj.Another = new AnotherClass();
            InternalExecute(obj);
            Console.ReadLine();
        }

        private static void InternalExecute(MyClass obj)
        {
            obj?.Another?.Execute();

            //if (obj != null && obj.Another != null)
            //{
            //    obj.Another.Execute(); 
            //}
        }
    }


    class MyClass
    {
        public AnotherClass Another { get; set; }

    }

    class AnotherClass
    {
        public void Execute()
        {
            Console.WriteLine("Another Execute");
        }
    }
}
