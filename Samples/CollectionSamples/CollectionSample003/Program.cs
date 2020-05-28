using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionSample003
{
    // C# 3 (理論上這應該會編譯失敗，但很奇妙在 VS2017/2019 卻是成功的，在 VS2013 倒是正常的發生編譯失敗 
    class Program
    {
        static void Main(string[] args)
        {
            //以前需要這樣寫
           //var people = new List<Person>{ new Person { Name = "Bill", Age = 30 }, new Person { Name = "John", Age = 20 } };

            var people = new List<Person> { {"Bill", 30 }, { "John", 20 } };
           
            foreach (var p in people)
            {
                Console.WriteLine(p.Name + " is " + p.Age + "years old");
            }
            Console.ReadLine();
        }
    }

    static class PersonExtesnion
    {

        public static void Add(this ICollection<Person> source, string name, int age)
        {
            source.Add(new Person { Name = name, Age = age });
        }
    }

    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }


}
