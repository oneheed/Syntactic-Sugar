using System;
using System.Collections.Generic;

namespace NullOperatorSample005
{
    /// <summary>
    /// C# 8.0 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new MyClass();
            var list = obj.Address;
            Console.WriteLine($"Address Count: {obj.GetAddressFieldsCount()}");
            obj.Address.Add("台北市");
            Console.WriteLine($"Address Count: {obj.GetAddressFieldsCount()}");
            obj.Address.Add("高雄市");
            Console.WriteLine($"Address Count: {obj.GetAddressFieldsCount()}");
            obj.Address.Add("台南市");
            Console.WriteLine($"Address Count: {obj.GetAddressFieldsCount()}");
            Console.ReadLine();
        }
    }

    public class MyClass
    {
        private List<string> _addresses;


        // C# 8.0 使用 null 聯合指派運算子的寫法
        public List<string> Address
        {
            get
            {
                return _addresses ??= new List<string>();
            }
        }

        // 老派的寫法
        //public List<string> Address
        //{
        //    get
        //    {
        //        if (_addresses == null)
        //        {
        //            _addresses = new List<string>();
        //        }
        //        return _addresses;
        //    }
        //}



        // 過去使用 null 聯合運算子的寫法
        //public List<string> Address
        //{
        //    get
        //    {
        //        _addresses = _addresses ?? new List<string>();
        //        return _addresses;
        //    }
        //}


        public int GetAddressFieldsCount()
        {
            return _addresses.Count;
        }

    }
}
