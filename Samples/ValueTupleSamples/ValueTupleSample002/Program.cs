using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ValueTupleSample002
{
    // C# 7.0 (.NET Core 2.0 / .NET Framework 4.7 / nuget)

    /// <summary>
    /// 使用 ValueTuple 作為方法的回傳值
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var numerics = Enumerable.Range(100, 999);
            var limitation = GetLimitation(numerics);
            Console.WriteLine($"{limitation.min} -- {limitation.max  }");
            var radius = 2.5;
            var (area, perimeter) = GetAreaAndPerimeter(radius);
            Console.WriteLine($"半徑為 {radius} 的圓其面積為 {area}, 周常為 {perimeter} ");

            Console.ReadLine();

        }



        static (int min, int max) GetLimitation(IEnumerable<int> source)
        {
            return (source.Min(), source.Max());
        }


        /// <summary>
        /// 傳入半徑取得圓的面積與周長
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>      
        static (double, double) GetAreaAndPerimeter(double radius)
        {
            return (Math.PI * (Math.Pow(radius, 2)), Math.PI * 2 * radius);
        }



    }


}
