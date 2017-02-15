using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Homework_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            try
            {
                a = int.Parse(Console.ReadLine());
                Console.WriteLine(a * 5);
            }
            catch (Exception)
            {
                Console.WriteLine("Only numbers are accepted");
            }
            finally
            {
                Console.WriteLine("Program has ended!");
            }
        }
    }
}
