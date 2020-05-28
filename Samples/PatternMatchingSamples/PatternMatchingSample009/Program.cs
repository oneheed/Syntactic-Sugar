using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingSample009
{
    // C#8.0

    /// <summary>
    /// Tuple pattern
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in Create())
            {
                Console.WriteLine(GetResult(item.first, item.second));

            }
            Console.ReadLine();
        }

        static List<(Morra first, Morra second)> Create()
        {
            return new List<(Morra first, Morra second)>
            {
                ( Morra.剪刀, Morra.布 ),
                ( Morra.布 , Morra.石頭 ),
                ( Morra.石頭 , Morra.剪刀 ),
                ( Morra.剪刀 , Morra.剪刀 ),
                ( Morra.石頭 , Morra.石頭 ),
                ( Morra.布  , Morra.布 ),
                ( Morra.剪刀, Morra.石頭 ),
                ( Morra.布 , Morra.剪刀 ),
                ( Morra.石頭 , Morra.布 ),

            };
        }


        static Result GetResult(Morra first, Morra second) => (first, second ) switch
        {           
            (Morra.剪刀, Morra.布) => Result.勝,
            (Morra.布, Morra.石頭) => Result.勝,
            (Morra.石頭, Morra.剪刀) => Result.勝,
            // (Morra x, Morra y) when x == y => Result.平,
            // 因為是 value type 所以用 var 也可以
            //(var x, var y) when x == y => Result.平,
            // var (x, y) when x == y => Result.平,
            // 在 discard 使用 when
            _ when first == second => Result.平,
            _ => Result.敗
        };
    }

    enum Morra
    {
        剪刀,
        石頭,
        布
    }

    enum Result
    {
        勝,
        敗,
        平
    }
}
