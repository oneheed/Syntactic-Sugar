using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingWithNullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = null;
            var result = GetAge(p);

            if (result == null )
            {
                Console.WriteLine("this person is null");
            }
            else
            {
                Console.WriteLine(result);
            }

            Console.ReadLine();
        }

        private static int? GetAge(Person p)
        {
            return p?.Age is int v ? v : default(int?);

           // is int? 是不合理的
           // return p?.Age is int? v ? v : 0;
        }

        private static string GetAgeString(Person p)
        {
            return p?.Age is int v ? v.ToString() : "0";
        }
    }


    class Person
    {
        public int? Age { get; set; }
    }
}
