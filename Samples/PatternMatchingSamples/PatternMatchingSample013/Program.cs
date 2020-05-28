using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingSample013
{
    // C# 8.0
    /// <summary>
    /// property pattern , 修改 010 專案
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
            { Operand: "+", X: var x, Y: var y } => x + y,
            { Operand: "-", X: var x, Y: var y } => x - y,
            { Operand: "*", X: var x, Y: var y } => x * y,
            { Operand: "/", Y: 0 } => double.NaN,
            { Operand: "/", X: var x, Y: var y } => x / y,
            { Operand: _ } => throw new ArgumentException("Operand should be one of +,-,*,/")
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
       
    }
}
