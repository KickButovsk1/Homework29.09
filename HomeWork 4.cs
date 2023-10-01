using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Один на суше  другой на море ";
            string[] rez;
            rez = s.Split(' ');
            Console.WriteLine("Результат разделения строки:");
            Console.WriteLine(rez[0]);
            Console.WriteLine(rez[1]);
            Console.WriteLine(rez[2]);
            Console.WriteLine(rez[3]);
            Console.WriteLine(rez[4]);
            Console.WriteLine(rez[5]);
            Console.WriteLine(rez[6]);
            Console.WriteLine(rez[7]);
            string s1 = string.Join(":", rez);
            Console.WriteLine("Результат соединения строки: ");
            Console.WriteLine(s1);
            Console.ReadKey();
        }
    }
}
