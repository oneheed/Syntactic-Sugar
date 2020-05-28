using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericConstraintSample002
{

    // C# 7.3

    /// <summary>
    /// enum 約束
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            var result = EnumNamedValues<DayOfWeek>();
            foreach (var item in result)
            {
                Console.WriteLine($" {item.Key} -- {item.Value}");
            }

            Console.ReadLine();
        }

        /// <summary>
        /// 多半應用在內部處理會使用 Enum 靜態方法的時候
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Dictionary<int, string> EnumNamedValues<T>() where T : System.Enum
        {
            var result = new Dictionary<int, string>();
            var values = Enum.GetValues(typeof(T));
            foreach (int item in values)
            {
                result.Add(item, Enum.GetName(typeof(T), item));
            }
            return result;
        }

    }






}
