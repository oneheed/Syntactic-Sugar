using System;

namespace InterfaceSample002
{
    // C# 8.0

    class Program
    {
        static void Main(string[] args)
        {
            IBase obj = new BaseClass2();
            obj.Request();
            ((IDerived)obj).Request();

            obj = new DrivedClass();
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

    abstract class AbstractClass : IBase
    {
        /// <summary>
        /// 重新抽象 Request 方法為沒有實作
        /// </summary>
        public abstract void Request();
    }

    class DrivedClass : AbstractClass
    {
        public override void Request()
        {
            Console.WriteLine($"Call {nameof(Request)} in {nameof(DrivedClass)}");
        }
    }

    interface IDerived : IBase
    {
        /// <summary>
        /// 重新抽象 Request 方法為沒有實作
        /// </summary>
        abstract void IBase.Request();
    }

   

    class BaseClass : IDerived
    {
        public void Request()
        {
            Console.WriteLine($"Call {nameof(Request)} in {nameof(BaseClass)}");
        }
    }

    interface IDerived2 : IBase
    {

    }

    /// <summary>
    /// 如果一個是 reabstraction, 一個有實作
    /// </summary>
    class BaseClass2 : IDerived, IBase
    {
        public void Request()
        {
            Console.WriteLine($"Call {nameof(Request)} in {nameof(BaseClass2)}");
        }

    }
}
