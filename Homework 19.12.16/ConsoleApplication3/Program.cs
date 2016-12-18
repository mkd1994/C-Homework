using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];

            for (int i = 0; i < 5; i++)
            {
                num[i] =Int32.Parse(Console.ReadLine());
 
            }
            Console.WriteLine("Max = " + num.Max());
            Console.WriteLine("Min = " + num.Min());
        }
    }
}
