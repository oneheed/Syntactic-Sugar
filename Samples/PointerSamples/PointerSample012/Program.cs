using System;
using System.Runtime.InteropServices;

namespace PointerSample012
{

    // C# 7.3
    class Program
    {
        static void Main(string[] args)
        {
            // 透過 ReadOnlySpan<T>(T[])
            var bytes = new byte[] { 0,1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var bytesSpan = new ReadOnlySpan<byte>(bytes);  
            foreach (var item in bytesSpan)
            {
                Console.WriteLine(item);
            }
         
            Console.WriteLine("============================");


            // 透過 ReadOnlySpan<T>(T[], Int32, Int32)
            var bytesSpan2 = new ReadOnlySpan<byte>(bytes, 1, 5);
            foreach (var item in bytesSpan2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------");
           

            // 透過 Span<T>(Void*, Int32) -- 比較少用
            IntPtr native = Marshal.AllocHGlobal(100);
            ReadOnlySpan<byte> nativeSpan;
            unsafe
            {
                nativeSpan = new ReadOnlySpan<byte>(native.ToPointer(), 100);
            }


            // 使用 stackalloc
            ReadOnlySpan<byte> stackSpan = stackalloc byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

          



            Console.ReadLine();
        }
    }
}
