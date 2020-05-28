using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertySample003
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
        }
    }

    class Rectangle
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public int Area => Width * Height;
    }

    class MyClass
    {
        public string Name => "Bill";
        public List<int> Numerics => new List<int> { 1, 2, 3, 4, 5 };
    }
}