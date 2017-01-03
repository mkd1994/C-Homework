using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        public static int sum = 1;

        public static int Step2(int a)
        {
            if (a == 0)
            {
                return sum;
            }
            sum *= a;
            return Step2(a - 1);
        }

        public static void Step1(int a)
    {
        Random rnd = new Random();
        for (int i = 0; i < Step2(a); i++)
        {
        }

    }
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            Step1(a);
        }
    }
}
