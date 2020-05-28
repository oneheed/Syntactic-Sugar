using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingSample011
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach (var item in Create())
            {
                if (item is (10, 10, string name))
                {
                    Console.WriteLine($"長寬都為 10 的矩形是 {name}");
                }
            }
            Console.ReadLine();
        }

        private static List<Rectangle> Create()
        {
            return new List<Rectangle>
            {
                { 10, 10, "矩形0"},
                { 0, 9, "矩形1" },
                { 10, 11, "矩形2" },
                { 3, 3, "矩形3" },
                { 10, 10, "矩形4"},
                { 10, 10, "矩形5"},
                {10,10, null },
                null,
            };
        }
    }


    /// <summary>
    /// 純粹為了偷懶
    /// </summary>
    static class ShapeExtensions
    {
        public static void Add(this ICollection<Rectangle> shapes, double width, double height, string name)
        {
            shapes.Add(new Rectangle { Width = width, Height = height, Name = name });
        }
    }
    static class RectangleExtension
    {
        public static void Deconstruct(this Rectangle r, out double width, out double height, out string name)
        {
            width = r.Width;
            height = r.Height;
            name = r.Name;
        }
    }

    class Rectangle
    {
        public string Name { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

    }

}
