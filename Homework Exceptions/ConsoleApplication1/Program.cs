using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Exceptions exp = new Exceptions();

            Console.Write("Email: ");
            exp.email = Console.ReadLine();
            Console.Write("Password: ");
            exp.password = Console.ReadLine();

            try
            {
                bool a = exp.password.Length > 5;
            }
            catch (Exception)
            {
                Console.WriteLine("Your password has to be more than 5 characters");
            }
        }
    }
}
