using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionSample002
{
    // C# 6
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(MakeRequest().GetAwaiter().GetResult());
            Console.ReadLine(); 
        }


        // 這只是個例子，一般通常是用 GetAsync 回傳的 HttpResponseMessage.StatusCode
        public static async Task<string> MakeRequest()
        {
            WebRequestHandler webRequestHandler = new WebRequestHandler();
            webRequestHandler.AllowAutoRedirect = false;
            using (HttpClient client = new HttpClient(webRequestHandler))
            {              
                try
                {
                    return await client.GetStringAsync("https://google.com");                  
                }               
                catch (System.Net.Http.HttpRequestException e) when (e.Message.Contains("301"))
                {
                    Debug.WriteLine(e);
                    return "Site Moved";
                }
                catch (System.Net.Http.HttpRequestException e)
                {
                    Debug.WriteLine(e);
                    return "Other exception";
                }

            }
        }

        
    }
}
