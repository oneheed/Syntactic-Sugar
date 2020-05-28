using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentSample001
{
    // C# 4
    class Program
    {
        static void Main(string[] args)
        {
            // 具名呼叫
            Console.WriteLine(Subtract(y: 10, x: 12));
            Console.WriteLine(Subtract(100, y: 9)); // 具名引數必須在位置引數後面

            //選擇性引數
            Console.WriteLine(Contact("Bill", "Chung"));
            Console.WriteLine(Contact("Bill", "Chung", "Jr."));


            Console.ReadLine();
        }


        static int Subtract(int x, int y)
        {
            return x - y;
        }

        /// <summary>
        /// 選擇性參數，要放在必要參數之後
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="middleName"></param>
        /// <param name=""></param>
        /// <returns></returns>
        static string Contact(string firstName, string lastName, string middleName = null)
        {
            if (string.IsNullOrEmpty(middleName))
            {
                return string.Format("{0} {1}", firstName, lastName);
            }
            else
            {
                return string.Format("{0} {1} {2}", firstName, middleName, lastName);
            }
        }

    }
}
