using System;

namespace InterfaceSample004
{
    // C# 8.0

    /// <summary>
    /// 覆寫衝突
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {        
            
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
        /// 覆寫 IBase.Request()
        /// </summary>
        void IBase.Request()
        {
           
            Console.WriteLine($"Call {nameof(Request)} in {nameof(IDerived)}");
        }
    }

    interface IDerived2 : IBase
    {
        /// <summary>
        /// 覆寫 IBase.Request()
        /// </summary>
        void IBase.Request()
        {           
            Console.WriteLine($"Call {nameof(Request)} in {nameof(IDerived2)}");
        }
    }

     class Derived : IDerived
    {

    }

    /// <summary>
    /// 會出現衝突
    /// </summary>
    //class BaseClass : IDerived, IDerived2
    //{

    //}
}
