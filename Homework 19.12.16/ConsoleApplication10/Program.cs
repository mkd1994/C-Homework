using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            int[] arr = new int[N];
            arr[0] = 0;
            arr[1] = 1;

            for (int i = 2; i < arr.Length; i++)
            {
                arr[i] = arr[i-2] + arr[i-1];
            }
            foreach (int value in arr)
                Console.WriteLine(value);
        }
    }
}
