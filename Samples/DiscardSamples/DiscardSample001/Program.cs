using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscardSample001
{
    // C# 7.0
    class Program
    {
        static void Main(string[] args)
        {
            // 超瞎範例
            _ = 3 * 4;
        }

        /// <summary>
        /// 區域變數使用 discards;
        /// </summary>
        static int Parse(string s)
        {

            int result;
            _ = int.TryParse(s, out result);
            return result;
        }

        /// <summary>
        /// out 引數使用 discards
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static bool IsParsed(string s)
        {
            return int.TryParse(s, out _);
        }
       
    }
}
