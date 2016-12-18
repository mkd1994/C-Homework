using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 12, 456, 312, 95, 237, 53, 82,41,84,34,45,52};

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i]==41)
                {
                    int indexer = i;
                    Console.WriteLine(indexer);
                }
            }
        }
    }
}
