using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullOperatorSample004
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = null;           
            Console.WriteLine(GetAge (p));
            p = new Person { Age = 15 };
            Console.WriteLine(GetAge(p));
            Console.ReadLine();

        }

        private static string GetAge(Person p)
        {          
                
           return p?.Age.ToString() ?? "persion is null";
        }
    }

    class Person
    {
        public int Age { get; set; }
    }
}
