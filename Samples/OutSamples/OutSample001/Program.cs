using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutSample001
{
    // C#7.0
    class Program
    {
        static void Main(string[] args)
        {
            string s= "123";
            // 以前要這樣寫
            int i;
            int.TryParse(s, out i);
            // 現在只要這樣寫
            int.TryParse(s, out int j);
        }
    }
}
