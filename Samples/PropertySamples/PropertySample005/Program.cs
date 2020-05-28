using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PropertySample005
{
    // C# 7.3
    class Program
    {
        static void Main(string[] args)
        {

            foreach (var field in typeof(MyClass).GetFields(BindingFlags.Instance | BindingFlags.NonPublic))
            {

                foreach (var attribute in field.GetCustomAttributes(false))
                {
                    Console.WriteLine($"{field.Name }.{attribute.ToString()}");
                }              

            }

            Console.WriteLine("====================");

            foreach (var property in typeof(MyClass).GetProperties())
            {

                foreach (var attribute in property.GetCustomAttributes(false))
                {
                    Console.WriteLine($"{property.Name }.{attribute.ToString()}");
                }

            }

            Console.WriteLine("====================");

            Console.ReadLine();

            
        }


    }


    public class MyClass
    {
        [field: Description("姓名")]
        public string Name { get; set; }


        
    }
}
