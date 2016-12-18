using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            int y = 4;
            int[,]arr=new int[i,y];

            for (int z = 0; z < i ; z++)
            {
                for (int f = 0; f < y; f++)
                {
                    arr[z, f] = Int32.Parse(Console.ReadLine());
                }
            }
        }
    }
}
