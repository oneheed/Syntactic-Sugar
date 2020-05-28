using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionSample002
{
    // C# 3
    // 集合初始設定式
    class Program
    {      

        static void Main(string[] args)
        {
            var people = new People { new Person { Name = "Bill", Age = 30 }, new Person { Name = "John", Age = 20 } };
            foreach (var p in people)
            {
                Console.WriteLine(p.Name + " is " + p.Age + "years old");
            }
            Console.ReadLine();
        }
    }

    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }


    /// <summary>
    /// 執行個體 Add 方法
    /// </summary>
    class People : IEnumerable<Person>
    {
        private List<Person> _people;
        public People()
        {
            _people = new List<Person>();
        }

        public void Add(Person p)
        {
            _people.Add(p);
        }
        public IEnumerator<Person> GetEnumerator()
        {
            return _people.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        
    }
}

