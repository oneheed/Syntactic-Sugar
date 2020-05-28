using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PointerSample002
{
    // C# 7.0
    class Program
    {
        static void Main(string[] args)
        {
            var vectors = new Vector2[10];
            vectors[3].X = 10;

            // var vector = vectors.First((x) => x.X == 10);
            var vector = vectors[Array.IndexOf(vectors, vectors.First((x) => x.X == 10))];
            vector.Y = 99;
            Console.WriteLine(vectors[3].Y);
            ref var refVector = ref vectors[Array.IndexOf(vectors, vectors.First((x) => x.X == 10))];
            refVector.Y = 99;
            Console.WriteLine(vectors[3].Y);
            Console.ReadLine();
        }
    }


}
