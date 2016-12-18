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
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int x = a;
            int y = b;

            if (a > b)
            {
                for (; 0 < b;)
                {
                    if ((a % b == 0) && (y % b == 0))
                    {
                        Console.WriteLine(b);
                        break;
                    }
                    b--;

                }
                
            }
            if (b > a)
            {
                for (; 0 < a; )
                {
                    if ((b % a == 0) && (x % a == 0))
                    {
                        Console.WriteLine(a);
                        break;
                    }
                    a--;

                }
            }

        }
    }
}
