using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd=new Random();
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 3);
            }
        }
    }
}
