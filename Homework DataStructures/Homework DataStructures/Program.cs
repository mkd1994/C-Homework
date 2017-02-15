using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            DataStructures data = new DataStructures();
            data.AvaregeListCount();

            List<int> list = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                var a = rnd.Next(1,6);
                list.Add(a);
            }
            foreach (int item in list)
            {
                Console.WriteLine(item + "*");
            }
            data.Removal(list);

            data.Words();

            data.PokerDeal();
        }
    }
}
