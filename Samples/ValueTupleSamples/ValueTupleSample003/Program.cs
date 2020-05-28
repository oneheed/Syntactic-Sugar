using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTupleSample003
{
    class Program
    {
        static void Main(string[] args)
        {
            MyRectangle rect = new MyRectangle() { Width = 10, Height = 30 };
            (double x, double y) = rect;

            (string name, double a, double d, double f) = rect;
            
            Console.WriteLine($"{x} -- {y}");

         (new MyRectangle() { Width = 5, Height = 8 }).Deconstruct(out double w, out double h);
            Console.WriteLine($"{w} -- {h}");
        }
    }

    public class MyRectangle
    {

        public string Name { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public double Area => Width * Height;

        public void Deconstruct(out double width, out double height)
        {
            width = this.Width;
            height = this.Height;
        }

        public void Deconstruct(out double width, out double height, out string name)
        {
            width = this.Width;
            height = this.Height;
            name = this.Name;
        }

    }

    public static class RectangleExtensions
    {
        public static void Deconstruct(this MyRectangle rect, out string name, out double area, out double width, out double height)
        {
            name = rect.Name;
            area = rect.Area;
            width = rect.Width;
            height = rect.Height;
        }
    }
}
