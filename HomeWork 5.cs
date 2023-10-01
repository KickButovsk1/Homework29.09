using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "(вайпернаин)майскайангел";
            int first = s.IndexOf("(");
            Console.WriteLine(first);
            int second = s.IndexOf(")");
            Console.WriteLine(second);
            if (first < second)
            {
                string slovo = s.Substring(first + 1, second - first - 1);
                Console.WriteLine("Все символы, расположенные между скобками: " + slovo);
            }
            Console.ReadKey();
        }
    }
}
