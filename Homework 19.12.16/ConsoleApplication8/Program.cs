using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]arr=new int[8]{1,2,3,4,4,3,2,1};
            int[] arr2 = new int[4];
            int a = arr.Length;
            int y = 0;
                for (int i = a/2; i < a; i++, y++)
                {
                    arr[i]=arr[y];

                }
                Array.Reverse(arr2);
                foreach (int value in arr2)
                {
                    Console.WriteLine(value);
                }
                foreach (int value in arr)
                {
                    Console.WriteLine(value);
                }
        }
    }
}
