using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericConstraintSample001
{
    // C#7.3

    /// <summary>
    /// delegate 約束
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Action a1 = new Action(() => Console.WriteLine("action 1"));
            Action a2 = new Action(() => Console.WriteLine("action 2"));
            var combine = a1.TypeSafeCombine(a2);

            Func<int> f1 = new Func<int>(() =>
           {
               Console.WriteLine("func 1");
               return 0;

           });

            // 不同的委派不可合併
            // combine = combine.TypeSafeCombine(f1); 



            Console.WriteLine();
        }

    }


    public static class MyClass
    {

        public static TDelegate TypeSafeCombine<TDelegate>(this TDelegate source, TDelegate target) where TDelegate : System.Delegate
        => Delegate.Combine(source, target) as TDelegate;
    }
}
