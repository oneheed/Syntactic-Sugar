using PointerSample006.DefensiveCopy;
using PointerSample006.NotCopy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointerSample006
{
    class Program
    {
        static void Main(string[] args)
        {
            var notCopy = new NotCopyStruct(10);
            ref readonly var notCopyRef = ref notCopy;
            notCopyRef.Request();

            var defensive = new DefensiveCopyStruct(99);
            ref readonly var defensiveRef = ref defensive;
            defensiveRef.Request();
        }
    }

  

  
}
