using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        public static int Method(int a, int b, int c)
        {
            int sum;
            return sum = a*b*c;
        }
        static void Main(string[] args)
        {
             Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int q = rnd.Next(1, 10);
                int w = rnd.Next(1, 10);
                int e = rnd.Next(1, 10);
                Console.WriteLine(Method(q, w, e));
            }
        }
    }
}
