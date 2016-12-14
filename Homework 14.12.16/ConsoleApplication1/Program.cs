using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your score from 1 - 9 interval");
            int i;
            double b;
            start:
            i=int.Parse(Console.ReadLine());
            if (i >= 1 && i <= 3)
            {
                Console.WriteLine(i + 5);
            }
            else if (i >= 4 && i <= 6)
            {
                Console.WriteLine(i * 12);
            }
            else if (i >= 7 && i <= 9)
            {
                b =Convert.ToDouble(i) * 50 / 3;
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine("Please stay within the interval");
                goto start;
            }
        }
    }
}
