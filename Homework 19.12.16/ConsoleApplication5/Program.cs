using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        public static double factorial(double i, double a)
        {
            a *= i;
            if (i == 1)
            {
                return a;
            }

            return factorial(i - 1, a);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Keep this formula in mind N>K>1 ");
            Console.Write("N = ");
            double N = Double.Parse(Console.ReadLine());
            Console.Write("K = ");
            double K = Double.Parse(Console.ReadLine());
            double sum2 = N - K;
            double sum = (factorial(N, 1) * factorial(K, 1))/factorial(sum2,1);

            Console.WriteLine(sum);
        }
    }
}
