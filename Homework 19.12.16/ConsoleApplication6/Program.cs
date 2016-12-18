using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 1, 3, 5, 7, 9 };
            int[] arr2= new int[5];

            for (int i = 0; i < 5; i++)
            {
                arr2[i]+= arr[i];
            }
            for (int y = 0; y < 5; y++)
            {
                Console.WriteLine(arr2[y]);
            }
        }
    }
}
