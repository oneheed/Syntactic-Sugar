using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunctionSample002
{
    class MyClass
    {
        private static int x = 0;
        public void Show()
        {
            var list1 = new List<string>() { "1", "2", "3", "4", "5" };
            var list = list1;
            Display(list);
            var list2 = new List<string>() { "A", "B", "C", "D", "E" };
            list = list2;
            Display(list);

            WriteX();

            // 區域函式1
            static void Display(IEnumerable<string> list)
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }

            // 區域函式2, 使用運算式主體
            static void WriteX() => Console.WriteLine(x);
        }
    }
}
