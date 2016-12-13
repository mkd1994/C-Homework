using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string a = Console.ReadLine();
            Console.Write("Enter N element: ");
            int N = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(a.ElementAt(N));
        }
    }
}
