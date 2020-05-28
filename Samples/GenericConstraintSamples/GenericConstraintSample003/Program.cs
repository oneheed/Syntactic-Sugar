using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericConstraintSample003
{
    // C# 7.3

        /// <summary>
        /// unmanaged 約束
        /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
        }

       
    }

    public static class MyClass
    {

        /// <summary>
        /// T 會被限制為結構
        /// 欄位只能擁有以下
        /// (1) sbyte，byte，short，ushort，int，uint，long，ulong，char，float，double，decimal，bool，IntPtr或UIntPtr
        /// (2) enum type
        /// (3) pointer type
        /// (4) 滿足 (1)(2)(3) 條件的自訂結構
        /// 解決 unsafe type 多載的問題
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="argument"></param>
        /// <returns></returns>
        unsafe public static byte[] ToByteArray<T>(this T argument) where T : unmanaged
        {
            var size = sizeof(T);
            var result = new Byte[size];
            Byte* p = (byte*)&argument;
            for (var i = 0; i < size; i++)
                result[i] = *p++;
            return result;
        }
    }
}
