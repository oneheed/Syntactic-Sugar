using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertySample001
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
        //private string _name;
        //public string Name
        //{
        //    get { return _name; }
        //    set { _name = value; }
        //}

        public string Name { get; set; } = "Bill";
        public List<int> Numerics { get; set; } = new List<int> { 1, 2, 3, 4, 5 };

       
    }
}
