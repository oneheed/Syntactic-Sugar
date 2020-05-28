using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionSample001
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        async static void Execute()
        {
            try
            {
                // do somethig;
            }
            catch (Exception)
            {
                await Task.Delay(1000);
            }
            finally
            {
                await Task.Delay(1000);
            }
        }
    }
}
