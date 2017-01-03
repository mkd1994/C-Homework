using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        public static void Check(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("{0} e chetno", a);
            }
            else Console.WriteLine("{0} e nechetno", a);
        }
        static void Main(string[] args)
        {
            int b = Int32.Parse(Console.ReadLine());
            Check(b);
        }
    }
}
