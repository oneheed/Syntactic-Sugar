using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultSample001
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "A", "B", "C" };
            var r1 = GetFirstorDefault(list, (x) => x == "C");
            Console.WriteLine(r1);
            var r2 = GetFirstorDefault(list, (x) => x == "D");
            if (r2 == null)
            {
                Console.WriteLine("r2 is null");
            }

            var numerics = new List<int>{ 9, 8, 7, 6, 5 };
            Console.WriteLine(GetFirstorDefault(numerics, (x) => x < 5));

            var nullNumerics = new List<int?> { 9, 8, 7, 6, 5 };
            var r3 = GetFirstorDefault(nullNumerics, (x) => x < 5);
            if (r3 == null)
            {
                Console.WriteLine("r3 is null");
            }

            Console.ReadLine();
        }

        static T GetFirstorDefault<T>(IEnumerable<T> source, Func<T, bool> predicate)
        {

            foreach (var item in source)
            {
                if (predicate (item))
                {
                    return item;
                }
            }
            return default;
        }

    }

}
