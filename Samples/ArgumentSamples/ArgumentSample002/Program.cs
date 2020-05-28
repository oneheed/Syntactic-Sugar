using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentSample002
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Subtract(x: 100, 9)); // 位置正確的話，具名引數也可以在前面

            // 這樣就不行, 因為位置不正確
            // Console.WriteLine(Subtract(y: 100, 9));

            Console.ReadLine();
        }

        static int Subtract(int x, int y)
        {
            return x - y;
        }
    }
}
