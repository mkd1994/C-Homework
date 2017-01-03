using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
     class Cat
    {
        public string name { get; set; }
        public int age { get; set; }

        public void Say()
        {
            Console.WriteLine("The cat is called {0} and he is {1} years old", name, age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat[] arr = new Cat[3];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Cat();
                arr[i].age = Int32.Parse(Console.ReadLine());
                arr[i].name = Console.ReadLine();
            }
            for (int x = 0; x < arr.Length; x++)
            {
                arr[x].Say();
            }
        }
    }
}
