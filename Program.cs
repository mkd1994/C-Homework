using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            char b= ' ';
            string a = "o";
            for (int x = 0; x < 4; x++)
            {
                Console.Write(a.Insert(x, a));
                Console.WriteLine(a.PadLeft(5-x, b));
            }
                
            Console.WriteLine("   |_|");
        }
    }
}
