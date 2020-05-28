using System;

namespace InterfaceSample001
{
    // C#8.0
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
        /// 此實作會被衍生型別視為明確介面實作 (預設存取修飾為 public)
        /// </summary>
        void Request()
        {
            Console.WriteLine($"Call {nameof(Request)} in {nameof(IBase)}");
        }
    }

    class BaseClass : IBase
    {
        /// <summary>
        /// 若衍生型別有相同簽章的成員，則忽略基底介面的實作成員, 
        /// 加入或取消以下程式碼註解測試
        /// </summary>
        public void Request()
        {
            Console.WriteLine($"Call {nameof(Request)} in {nameof(BaseClass)}");
        }


    }
}
