using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static string url;
        static void Main(string[] args)
        {
            MakeAcc acc = new MakeAcc("http://regosp.top:2082/");
          
            while(true)
            {
                Console.WriteLine("begin y,n?");
                if (Console.ReadLine().Trim() == "y")
                {
                    url = acc.dr.Url;
                    break;
                }

            }

            string[] domains = File.ReadAllLines("domain.txt");
          
            foreach (string domain in domains)
            {
                acc.PutDomain(url,domain);
               
            }


           

        }
    }
}
