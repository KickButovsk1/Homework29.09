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


            string str = "Это тест";
            string s2 = " простой ";
            s2 = str.Insert(3 ,s2);
            Console.WriteLine(s2);
            Console.ReadKey();

        }
    }
}
