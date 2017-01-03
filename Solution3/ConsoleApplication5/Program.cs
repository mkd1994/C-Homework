using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Recursion(a));
        }
        public static int sum = 1;

        private static int Recursion(int a)
        {
            if (a == 0)
            {
                return sum;
            }
            sum *= a;
            return Recursion(a-1);
        }
    }
}
