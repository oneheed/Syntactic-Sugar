using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingSample010
{
    // C# 8.0
    /// <summary>
    /// position pattern
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in CreateList())
            {
                try
                {
                    Console.WriteLine(Calculate(item));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine("===================");

            Console.WriteLine(CalculateWithWhen(new MyExpression("*", 0, 12)));
            Console.WriteLine(CalculateWithWhen(new MyExpression("/", 100, 0)));
            Console.ReadLine();
        }

        static List<MyExpression> CreateList() =>
        new List<MyExpression>
        {
             new MyExpression ("+", 1, 2.3),
             new MyExpression ("-", 14.5, 0.1),
             new MyExpression ("*", 8, 1.5),
             new MyExpression ("/", 9, 2),
             new MyExpression ("/", 10, 0),
             new MyExpression ("NotOperand", 10, 10),
        };



        static double Calculate(MyExpression expression) => expression switch
        {
            ("+", var x, var y) => x + y,
            ("-", var x, var y) => x - y,
            ("*", var x, var y) => x * y,
            ("/", _, 0) => double.NaN,
            ("/", var x, var y) => x / y,
            _ => throw new ArgumentException("Operand should be one of +,-,*,/")
        };

        /// <summary>
        /// 加上 when 更誇張, 故意不合理回傳 -1
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        static double CalculateWithWhen(MyExpression expression) => expression switch
        {
            ("+", var x, var y) => x + y,
            ("-", var x, var y) => x - y,
            ("*", var x, var y) when x == 0 || y == 0 => -1,
            ("*", var x, var y) => x * y,
            ("/", _, 0) => double.NaN,
            //("/", _, var y) when y ==0 => double.NaN,
            ("/", var x, var y) => x / y,
            _ => throw new ArgumentException("Operand should be one of +,-,*,/")
        };

    }

    class MyExpression
    {
        public MyExpression(string operand, double x, double y)
        {
            Operand = operand;
            X = x;
            Y = y;
        }
        public string Operand { get; }
        public double X { get; }
        public double Y { get; }


        /// <summary>
        /// Deconstruct 也可以用 extension method
        /// </summary>
        /// <param name="operand"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Deconstruct(out string operand, out double x, out double y)
        {
            operand = Operand;
            x = X;
            y = Y;
        }
    }

}
