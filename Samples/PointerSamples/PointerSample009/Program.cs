using System;
using System.ComponentModel;

namespace PointerSample009
{
    // C# 7.2
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            object o = i;
            
            Console.WriteLine((new MyRefStruct ()).ToString() );           
            Console.ReadLine();
        }
    }


    /// <summary>
    /// Equals 和 GetHashCode 要變成無法使用
    /// </summary>
    public ref struct MyRefStruct
    {
        public int Value1;
        public int Value2;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => throw new NotSupportedException();

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => throw new NotSupportedException();

       
        public override string ToString()
        {           
            return (typeof(MyRefStruct).ToString ());
        }
    }
}
