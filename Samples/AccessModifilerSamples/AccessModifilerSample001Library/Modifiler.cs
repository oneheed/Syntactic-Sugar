using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifilerSample001Library
{
    public class Modifiler
    {
        public void PublicMethod()
        { }

        // internal and protected
        private protected void PrivateProtectedMethod()
        {

        }
    }

    public class Other
    {
        public void Exec()
        {
            var modifiler = new Modifiler();
            modifiler.PublicMethod();
           // 同一個組件，但並非子類別者不可使用 private protected 宣告的成員
          //  modifiler.PrivateProtectedMethod();
        }
    }

    public class Derived : Modifiler
    {
     
        public void Exec()
        {
            // 在同一個組件的子類別可以使用 private protected 宣告的成員
            PrivateProtectedMethod();
        }
    }
}
