using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapitalBankApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            WebApp();
            MobileApp();
            API();
            Console.ReadLine();
        }
        public static void WebApp()
        {
            Console.WriteLine("This is WebApplication.");
        }
        public static void MobileApp()
        {
            Console.WriteLine("This is MobileApp.");
        }
        public static void API()
        {
            Console.WriteLine("This is API.");
        }
    }
}
