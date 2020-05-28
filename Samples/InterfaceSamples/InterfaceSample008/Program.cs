using System;

namespace InterfaceSample008
{
    // C# 8.0

    /// <summary>
    /// 變數型別會影響呼叫結果, 與 001 比較
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {  
            IBase obj = new BaseClass();
            obj.Request();
            ((BaseClass)obj).Request();

            Console.WriteLine();
        }
    }

  

    interface IBase
    {
        /// <summary>
        ///  sealed 只能用在繼承樹上的第一個方法的宣告
        ///  拓展的 interfaces 不可使用 sealed override
        /// </summary>
        sealed void Request()
        {
            Console.WriteLine($"Call {nameof(Request)} in {nameof(IBase)}");
        }

        // void Request();

    }

    /// <summary>
    /// 在 class 中會變成明確介面實作
    /// </summary>
    class BaseClass : IBase
    {
        public void Request()
        {
            Console.WriteLine($"Call {nameof(Request)} in {nameof(BaseClass)}");
        }
       
    }



    // 不允許在 interface 中覆寫
    //interface IBase2 : IBase
    //{
    //    void IBase.Request()
    //    {
    //        Console.WriteLine($"Call {nameof(Request)} in {nameof(IBase2)}");
    //    }
    //}




}
