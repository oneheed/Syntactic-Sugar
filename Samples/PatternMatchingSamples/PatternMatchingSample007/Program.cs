using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingSample007
{
    // C# 8.0
    /// <summary>
    /// switch expression 遇到 Nullable 的困擾
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var shape in GetObjects())
            {
                var result = GetArea(shape);
                if (result != null)
                {
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("this is null");
                }
            }

            Console.ReadLine();
        }

        static double? GetArea(object shape) => shape switch
        {
            
            Rectangle r when r.Width > 0 && r.Height > 0 =>  r.Width * r.Height ,
            Circle c when c.Radius > 0 =>Math.Pow(c.Radius, 2) * Math.PI,
            // 這樣會變成 0
            //_ => default,
            // 這樣會編譯失敗
            // _ => null
            // 這樣才會正確
             _ => default(double?)
        };


        static List<object> GetObjects() =>
            new List<object>
            {
                new Rectangle {Width = 0, Height = 10},
                new Rectangle {Width = 10, Height = -1},
                new Circle { Radius = 0 },
                new Circle { Radius = -2 },
                new Rectangle { Width = 5, Height =5 },
                new Rectangle { Width = 15, Height =5 },
                new Circle { Radius = 6 },
                new Rectangle { Width = 5, Height =5 },
                new Circle { Radius = 10 },
            };
    }


    class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    class Circle
    {
        public double Radius { get; set; }
    }
}
