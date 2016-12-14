using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] teste={"2","3","4","5","6","7","8","9","10","J","Q","K","A"};
            string a = Console.ReadLine();
            for (int i = 0; i < teste.Length; i++)
            {
                if (a == teste[i])
                {
                    Console.WriteLine("Valid card");
                    goto end;
                }
            }
            Console.WriteLine("Invalid Card");
        end: ;
        } 
    }
}
