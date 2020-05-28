using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTupleSample004
{

    // C# 7.3
    class Program
    {
        static void Main(string[] args)
        {

            var y = (1, 2, 3, 4, 5, 6, 7, "8" );

         
            
            var x1 = (1, "ABC");
            var x2 = (1, "ABC");

            // C# 7.0~7.2
            Console.WriteLine(x1.Equals(x2));

            // C# 7.3 
            Console.WriteLine(x1 == x2);

            // C# 7.0 (所有元素都必須實作 IComparable<T> ，否則會發生例外
            Console.WriteLine(x1.CompareTo(x2));

           var o1 = (1, new Person() {Name ="Bill"});
            var o2 = (1, new Person() { Name = "Andy" });
            Console.WriteLine(o1.CompareTo(o2));
            
            Console.ReadLine();
        }
    }


    /// <summary>
    /// 
    /// </summary>
    class Person : IComparable <Person>
    {
        public string Name { get; set; }

        public int CompareTo(Person other)
        {
           return  Name.CompareTo(other.Name);
        }
    }
}
