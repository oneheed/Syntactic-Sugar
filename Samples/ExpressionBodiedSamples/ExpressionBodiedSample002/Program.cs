using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionBodiedSample002
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person(null);
            var p2 = new Person("Bill");
            p2.Name = null;
            Display(null);
            Display("Bill");
            Console.ReadLine();
        }

        private static void Display(string s)
        {
           _ = s ?? throw new ArgumentNullException(nameof(s), " 不可為 null");
            Console.WriteLine($"傳入的參數: {s}");
        }
        
    }

   class Person
    {

        public Person (string name)
        {
            _name = name ?? throw new ArgumentNullException(nameof(name), " 不可為 null");            
        }
        private string _name;

        public string Name
        {
            get =>  _name;
            set => _name = value ?? throw new ArgumentNullException(nameof(Name),  " 不可為 null");
        }
    }
}
