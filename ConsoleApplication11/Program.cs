using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 0; x < 5; x++)
            {
                Console.Write(new string(' ', 5 - x)+new string('o',1+x));
                Console.WriteLine(new string('o', 0 + x));
            }
            for(int i=0;i<1;i++)
            {
                Console.WriteLine(new string(' ', 5) + new string('o', 1));
            }
        }
    }
}
