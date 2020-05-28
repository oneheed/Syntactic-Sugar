using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullOperatorSample001
{
    // C# 6, .NET Framework 4.5
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    /// <summary>
    /// null 條件運算子用在 event 
    /// </summary>
    class MyClass
    {
        public event EventHandler XChanged;

        //private void OnXChanged()
        //{
        //    if (XChanged != null)
        //    {
        //        XChanged.Invoke(this, EventArgs.Empty);
        //    }
        //}
        private int _x;
        public int X
        {
            get { return _x; }
            set
            {
                if (_x != value)
                {
                    XChanged?.Invoke(this, EventArgs.Empty); 
                }
            }
        }
    }
}
