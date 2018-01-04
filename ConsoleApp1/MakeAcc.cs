using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MakeAcc
    {
        string filename = "result.txt";
        string error = "error.txt";
        

        public ChromeDriver dr;

     



        public MakeAcc(string url )
        {
            dr = new ChromeDriver();
            dr.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 50));
            dr.Url = url; 
        }

        internal void PutDomain(string url, string domain)
        {
           
            dr.Url = url;

            dr.FindElementById("domain").SendKeys(domain);
            dr.FindElementById("subdomain").SendKeys(RandomString(7));
            dr.FindElementById("dir").Clear();
            dr.FindElementById("dir").SendKeys("public_html/base");
            dr.FindElementByCssSelector("#submit_domain").Click();

        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }

      
}
