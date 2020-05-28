using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointerSample006.DefensiveCopy
{
    public struct DefensiveCopyStruct
    {
        private readonly int _x;
        public int X => _x;
        public DefensiveCopyStruct(int x)
        {
            _x = x;
        }

        public void Request()
        {

            Console.WriteLine(_x.ToString());
        }
    }

    public class DefensiveCopyClass
    {
        private readonly DefensiveCopyStruct _data;

        public DefensiveCopyClass(DefensiveCopyStruct data)
        {
            _data = data;
        }

        public void Exec(in DefensiveCopyStruct x)
        {
           // var v0 = x;
           // v0.Request();
            x.Request();
        }

        public void Show()
        {
           //var d = _data;
           // d.Request();
            _data.Request();
        }
    }
}
