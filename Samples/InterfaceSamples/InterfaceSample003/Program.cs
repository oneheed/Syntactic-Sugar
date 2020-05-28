using System;

namespace InterfaceSample003
{
    // C# 8.0
    class Program
    {
        static void Main(string[] args)
        {
            IBase obj = new BaseClass();
            obj.Request();

            Console.WriteLine();
        }
    }

    interface IBase
    {
        /// <summary>
        /// 此實作會被衍生型別視為明確介面實作
        /// </summary>
        void Request()
        {
            Console.WriteLine($"Call {nameof(Request)} in {nameof(IBase)}");
        }
    }
    interface IDerived : IBase
    {
        /// <summary>
        /// 覆寫 IBase.Request(), 只允許顯式覆寫 (也就是加上 interface name)
        /// </summary>
        void IBase.Request()
        {
           
            Console.WriteLine($"Call {nameof(Request)} in {nameof(IDerived)}");
        }
    }

    interface IDerived2 : IDerived
    {
        /// <summary>
        /// reabstraction
        /// </summary>
        abstract void IBase.Request();
        
    }

    class BaseClass : IDerived
    {
       
    }

    //這樣又惹出一堆麻煩
    //class BaseClass2 : IDerived, IDerived2
    //{
        
    //}



}
