using System;
using System.Runtime.InteropServices;

namespace PointerSample010
{

    // C# 7.3 (主要是因為 stackalloc), .NET Core 2.1 (Span<T>)
    /// <summary>
    /// 建立 Span<T>, 透過建構式與 stackalloc
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // 透過 Span<T>(T[])
            var bytes = new byte[10];
            var bytesSpan = new Span<byte>(bytes);          

            byte data = 0;
            for (int ctr = 0; ctr < bytesSpan.Length; ctr++)
            {
                bytesSpan[ctr] = data;
                data++;
            }
            
            foreach (var item in bytesSpan)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------");
            foreach (var item in bytes)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("============================");


            // 透過 Span<T>(T[], Int32, Int32)
            var bytesSpan2 = new Span<byte>(bytes, 1, 5);
            foreach (var item in bytesSpan2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------");
            bytesSpan2[0] = 99;
            foreach (var item in bytes)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("============================");
            // 透過 Span<T>(Void*, Int32) -- 比較少用
            IntPtr native = Marshal.AllocHGlobal(100);
            Span<byte> nativeSpan;
            unsafe
            {
                nativeSpan = new Span<byte>(native.ToPointer(), 100);
            }


            // 使用 stackalloc (C# 7.2)
            Span<byte> stackSpan = stackalloc byte[100];
            // C# 7.3 stackalloc 加入陣列初始設定式
            Span<byte> stackSpan2 = stackalloc byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // stackalloc 也可以用在指標類型
            unsafe
            {
                byte* pointers = stackalloc byte[100];
            }



            Console.ReadLine();
        }
    }
}
