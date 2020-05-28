using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscardSample002
{

    // C# 7.0
    class Program
    {
        static void Main(string[] args)
        {

            // var (_, _, area) = GetRectangle();
            (_, _, int area) = GetRectangle();
            Console.WriteLine(area);

            // var (width, height, _ ) = new Rectangle() { Width = 9, Height = 6 };
            (int width, int height, _) = new Rectangle() { Width = 9, Height = 6 };

            Console.WriteLine($"{width} : {height}");
            Console.ReadLine();
        }

        static (int, int, int) GetRectangle()
        {
            return (7, 8, 7 * 8);
        }
    }

    class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public void Deconstruct(out int width, out int height, out int area)
        {
            width = Width;
            height = Height;
            area = Width * Height;
        }
    }
}
