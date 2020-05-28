using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointerSample006.NotCopy
{
    public readonly struct NotCopyStruct
    {
        private readonly int _x;
        public int X => _x;
        public NotCopyStruct(int x)
        {
            _x = x;
        }

        public void Request()
        {
           
            Console.WriteLine(_x.ToString());
        }

    }

    public class NotCopyClass
    {
        private readonly NotCopyStruct _data;
        
        public NotCopyClass (NotCopyStruct data)
        {
            _data = data;
        }

        public void Exec(in NotCopyStruct x)
        {
            x.Request ();
        }

        public void Show()
        {
            _data.Request();
        }
    }
}
