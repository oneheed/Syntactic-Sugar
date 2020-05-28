using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionSample001
{
    // C# 6
    class Program
    {
        static void Main(string[] args)
        {
            // 集合初始設定式 C# 3
            var dic1 = new Dictionary<string, int> { { "Bill", 1 }, { "John", 2 } };
           // dic1.Add("Bill", 5 );
            // 索引子初始化關聯集合, 注意第三個
            var dic2 = new Dictionary<string, int> { ["Bill"] = 1, ["John"] =2, ["Bill"] =5 };
            // 等同以下
            var dic3 = new Dictionary<string, int>();
            dic3["Bill"] = 1;
            dic3["John"] = 2;
            dic3["Bill"] = 5;

            foreach (var d in dic2)
            {
                Console.WriteLine($"{d.Key} : {d.Value}");
            }

            
            Console.ReadLine();
        }
    }

    class Pereson
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
