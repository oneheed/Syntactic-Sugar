using System;

namespace InterfaceSample007
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var obj = new DerivedClass();
            obj.RequestBase();
            ((IBase)obj).Request();
            DerivedClass.Request();

           


            Console.ReadLine();
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

    class BaseClass 
    {
        /// <summary>
        /// 若衍生型別有相同簽章的成員，則忽略基底介面的實作成員
        /// </summary>
        public void RequestBase()
        {
          
            Console.WriteLine($"Call {nameof(RequestBase)} in {nameof(BaseClass)}");
        }
    }


    /// <summary>
    /// 可以定義和介面實作執行個體方法或靜態方法相同簽章的靜態方法
    /// 但不能定義與父類別執行個體方法相同的靜態方法
    /// </summary>
    class DerivedClass : BaseClass , IBase
    {
        public static void Request()
        {
            Console.WriteLine($"Call {nameof(Request)} in {nameof(DerivedClass)}");
        }



        //public static void RequestBase()
        //{
        //    Console.WriteLine($"Call {nameof(RequestBase)} in {nameof(DerivedClass)}");
        //}
    }

}
