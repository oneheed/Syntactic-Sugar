using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertySample004
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class MyClass
    {
        private string _name;
        public string Name
        {
            get => _name;

            set => _name = value;
        }
    }
   
}
