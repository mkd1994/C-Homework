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
            string a;
            a = Console.ReadLine();
            int b; double c;

            if (int.TryParse(a,out b))
            {
                b++;
                Console.WriteLine("You choose to display a Integer - "+b);
            }
            else if (double.TryParse(a, out c))
            {
                c++;
                Console.WriteLine("You choose to display a Double - "+c);
            }
            else 
            {
                Console.WriteLine(a + "*");
            }
        }
    }
}
