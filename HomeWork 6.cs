using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "вайп::ерв!!се";
            string str1 = ":";
            string str2 = "!";
            int dlinna = str.Length;
            int first = dlinna / 2;
            string p = str.Substring(0, first);
            string p1 = str.Substring(first);
            if (p.Contains(":") && p1.Contains("!"))
            {
                string r = str.Replace(":", "*");
                string r2 = r.Replace("!", ".");
                Console.WriteLine("Cтрока -  " + r2);
            }
            Console.ReadKey();
        }
    }
}
