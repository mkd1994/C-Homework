using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        public static void Greet(string a)
        {
            Console.WriteLine("Greetings {0}", a);
        }
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Greet(name);
        }
    }
}
