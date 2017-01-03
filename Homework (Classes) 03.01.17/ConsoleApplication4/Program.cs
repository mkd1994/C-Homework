using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    abstract class Automobile
    {
        public double price { get; set; }
    }
    public class Car : Automobile
    {
        public int fuel_mile { get; set; }
    }
    public class SUV : Automobile
    {
        bool highgear = true;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Automobile[] arr = new Automobile[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Car();
                arr[i].fuel_mile = Int32.Parse(Console.ReadLine());
                arr[i].price = Int32.Parse(Console.ReadLine());
            }
        }
    }
}
