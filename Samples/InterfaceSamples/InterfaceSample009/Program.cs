using System;

namespace InterfaceSample009
{
    // C# 8.0

        /// <summary>
        /// interface 中的靜態建構式
        /// interface 不能包含執行個體建構式
        /// 將 obj 變數改成 var , IBase static Constructor 就不會執行 
        /// </summary>
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

        static IBase()
        {
            Console.WriteLine($"{nameof(IBase)} static constructor run");
        }
        void Request()
        {
            Console.WriteLine($"Call {nameof(Request)} in {nameof(IBase)}");
        }
    }

    class BaseClass : IBase
    {
        public BaseClass ()
        {
            Console.WriteLine($"{nameof(BaseClass)} constructor run");
        }
    }

    
}
