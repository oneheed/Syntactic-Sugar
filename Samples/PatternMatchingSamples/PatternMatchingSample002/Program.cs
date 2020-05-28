using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingSample002
{
    // C# 7.0
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<IShape>{ 
                        new Rectangle { Width = 10, Height = 10, Name ="矩形"  },
                        new Circle { Radius = 3.2 , Name= "圓形"},
                        new Line { Length = 4.9 , Name="直線"},
                        null };

            foreach (var shape in shapes )
            {
                try
                {
                    Console.WriteLine ($"{shape?.Name} 的面積是 {GetArea (shape)}");
                       
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }                
            }
            Console.ReadLine();

        }

        static double GetArea(IShape shape)
        {
            switch (shape )
            {
                // 這個 case 被稱為˙ null 比對模式
                case null:
                    throw new ArgumentNullException(nameof(shape), "不要傳 null");
                case Rectangle r:
                    return r.Width * r.Height;
                case Circle c:
                    return Math.Pow(c.Radius, 2) * Math.PI;
                default:
                    throw new ArgumentException($"{shape.Name} 形狀不符");
                    //case var _:
                    //    throw new ArgumentException($"{shape.Name} 形狀不符 var");

            }
        }
    }

    interface IShape
    {
        string Name { get; set; }
    }

    class Rectangle : IShape
    {
        public string Name { get; set; }

        public double Width {get; set;}

        public double Height { get; set; }
        
    }
    class Circle : IShape
    {
        public string Name { get; set; }

        public double Radius { get; set; }
    }

    class Line : IShape
    {
        public string Name { get; set; }

        public double Length { get; set; }
    }
}
