using AccessModifilerSample001Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifilerSample001
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class OutsideDerived : Modifiler
    {


        public void Exec()
        {
           // 在不同組件的子類別無法使用 private protected 宣告的成員
           // PrivateProtectedMethod();
        }
    }
}
