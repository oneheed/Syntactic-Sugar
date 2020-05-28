using System;

namespace InterfaceSample005
{
    // C# 8.0

    class Program
    {
        static void Main(string[] args)
        {
            var o1 = new BaseClass();
            o1.PublicRequest();
            ((IBase)o1).InternalRequest();


            IDerived  o2 = new Derived();
            o2.PublicRequest();

            Console.WriteLine();
        }
    }

    /// <summary>
    /// 存取修飾詞
    /// </summary>
    interface IBase
    {
        
        private void PrivateRequest()
        {
            Console.WriteLine($"Call {nameof(PrivateRequest)} in {nameof(IBase)}");
        }

        protected void ProtectedRequest()
        {
            Console.WriteLine($"Call {nameof(ProtectedRequest)} in {nameof(IBase)}");
            PrivateRequest();
        }

        internal void InternalRequest()
        {
            Console.WriteLine($"Call {nameof(InternalRequest)} in {nameof(IBase)}");
        }
    }

    class BaseClass : IBase
    {
        public void PublicRequest()
        {
            Console.WriteLine($"Call {nameof(PublicRequest)} in {nameof(BaseClass)}");

           
            // 衍生的類別看不見 protected member
            // base 專指 base class            
            //ProtectedRequest();
            //((IBase)this).ProtectedRequest();

            // 但是可以使用 internal member
            ((IBase)this).InternalRequest();           
        }
    }

    interface IDerived : IBase
    {
        void PublicRequest()
        {
            // 介面拓展就可以使用 protected member
            Console.WriteLine($"Call {nameof(PublicRequest)} in {nameof(IDerived)}");
            ProtectedRequest();
        }
    }

    class Derived : IDerived
    {

    }
}
