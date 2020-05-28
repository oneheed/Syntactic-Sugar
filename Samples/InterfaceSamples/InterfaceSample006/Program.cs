using System;

namespace InterfaceSample006
{
    // C# 8.0

    /// <summary>
    /// 在 interface 定義靜態方法
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IBase.Request();

            Console.ReadLine();
            
        }
    }

    interface IBase
    {       
        static void Request()
        {
            Console.WriteLine($"Call {nameof(Request)} in {nameof(IBase)}");
        }

        
    }

    

}
