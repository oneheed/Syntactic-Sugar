using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointerSample001
{
    // C#7.0
    class Program
    {
        static void Main(string[] args)
        {


            Before();
            After();

            Console.ReadLine();
        }

        static void Before()
        {
            int number = 100;
            unsafe
            {             
                int* p = &number;
                Console.WriteLine(*p);
                *p = 999;
                Console.WriteLine(number);
            }
        }

        static void After()
        {
            int number = 100;
            ref int p = ref number;
          
            Console.WriteLine(p);
            p = 999;
            Console.WriteLine(number); 
        }
    }
}
