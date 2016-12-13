using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Izberete chislo desetichno!");
            double a = Convert.ToDouble(Console.ReadLine());
            double c;
            int b = 7;

            c = a / Convert.ToDouble(b);

            Console.WriteLine(c);
        }
    }
}
