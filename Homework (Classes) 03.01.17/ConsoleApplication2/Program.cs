using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class TempConvert
    {
        public static double Conv(double a)
        {
            double F;
            return F = a*1.8 + 32;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int b = 32;
            Console.WriteLine(TempConvert.Conv(b));
        }
    }
}
