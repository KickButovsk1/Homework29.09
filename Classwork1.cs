using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BoolProject
{
    class Program
    {
        static void Main(string[] args)
        {


            string str = "C# обладает эффективными средствами обработки строк";
            string str2 = "о";
            string str3 = "ми";
            string str4 = "а";
            bool x = str.StartsWith("C# обладает");
            bool y = str.EndsWith("строк");
            int i = str.IndexOf(str2);
            int i2 = str.LastIndexOf(str2);
            int i3 = str.IndexOf(str3);
            int i4 = str.LastIndexOf(str3);
            Console.WriteLine(i);
            Console.WriteLine(i2);
            Console.WriteLine(i3);
            Console.WriteLine(i4);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(Math.Min(i, i2));
            Console.WriteLine(Math.Min(i2, i3));
            Console.WriteLine(Math.Min(i3, i4));
            Console.ReadKey();

        }
    }
}
