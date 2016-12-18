using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
