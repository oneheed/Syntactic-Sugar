using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointerSample005
{
    // C# 7.2
    /// <summary>
    /// 和 PointerSample004 比較，觀察參考型別和實值型別的不同
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var objs = new MyClass[5] { new MyClass(), new MyClass(), new MyClass(), new MyClass(), new MyClass() };
            objs[3].X = 10;

            // 確保 obj 變數內容不會被修改
            ref readonly var obj = ref First(objs, ((x) => x.X == 10));
            obj.Y = 99;
            Console.WriteLine(objs[3].Y);
            // obj = new MyClass();

            Console.ReadLine();
        }

        static ref MyClass First(MyClass[] objs, Func<MyClass, bool> predicate)
        {
            return ref objs[Array.IndexOf(objs, objs.First(predicate))];
        }
    }

    class MyClass
    {
        public int X { get; set; }

        public int Y { get; set; }
    }
}
