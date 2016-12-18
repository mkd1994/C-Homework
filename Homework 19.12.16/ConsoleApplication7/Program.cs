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
            int[] arr = new int[5] { 1,2,3,4,5 };
            Array.Reverse(arr);
            foreach(int value in arr)
            {
                Console.WriteLine(value);
            }
        }
    }
}
