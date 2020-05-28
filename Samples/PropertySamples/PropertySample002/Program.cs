using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertySample002
{
    // C# 6
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new MyClass();
            Console.WriteLine(obj.Name);
            foreach (var item in obj.Numerics)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }

    class MyClass
    {

        public string Name { get; } = "Bill";
        public List<int> Numerics { get; }
        public MyClass ()
        {
            Numerics = new List<int> { 1, 2, 3, 4, 5, 6 };
        }
    }
}
