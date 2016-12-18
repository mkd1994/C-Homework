using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5, };
            int[] arr2 = new int[5] { 1, 2, 3, 6, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == arr2[i])
                {
                    Console.WriteLine("Arr[{0}] is same? {1}",i,true);
                }
                else { Console.WriteLine("Arr[{0}] is same? {1}", i,false); }
            }
        }
    }
}
