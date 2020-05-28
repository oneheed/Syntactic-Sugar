using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace PointerSample003
{
    // C#7.0
    class Program
    {
        static void Main(string[] args)
        {
            var vectors = new Vector2[10];
            vectors[3].X = 10;
            ref var vector = ref First(vectors, ((x) => x.X == 10));
            vector.Y = 99;
            Console.WriteLine(vectors[3].Y);
            vector = new Vector2();
            Console.WriteLine(vectors[3].Y);

            Console.ReadLine();
        }

        static ref Vector2 First(Vector2[] vectors, Func<Vector2, bool> predicate)
        {
            return ref vectors[Array.IndexOf(vectors, vectors.First(predicate))];
        }


    }
}
