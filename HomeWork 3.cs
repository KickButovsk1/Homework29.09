using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "это простой тест";
            Console.WriteLine($"Исходная строка: " + s1);
            string s2 = s1.Replace("простой", "непростой");
            Console.WriteLine($"Новая строка: " + s2);
            string s3 = s2.Replace("непростой", "нопростой");
            string s4 = s3.Replace("тест","тост");
            Console.WriteLine($"Новая строка: " + s4);
            Console.ReadKey();
        }
    }
}
