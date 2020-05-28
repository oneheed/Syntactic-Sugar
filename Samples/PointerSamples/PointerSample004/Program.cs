using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PointerSample004
{
    // C# 7.2

    /// <summary>
    /// 修改自 PointerSample003
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var vectors = new Vector2[10];
            vectors[3].X = 10;

            // 確保 vector 變數內容不會被修改
            ref readonly var vector = ref First(vectors, ((x) => x.X == 10));
          //  vector = new Vector2();
           // vector.Y = 99;
            Console.WriteLine(vectors[3].Y);

            Console.ReadLine();
        }

        static ref Vector2 First(Vector2[] vectors, Func<Vector2, bool> predicate)
        {
            return ref vectors[Array.IndexOf(vectors, vectors.First(predicate))];
        }
    }
}
