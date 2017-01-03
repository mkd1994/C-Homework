using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class RightTriangle
    {
        private double katet;
        private double katet2;
        private double hipotez;

        public void Resign(double a, double b)
    {
            katet = a;
            katet2 = b;
    }

        public double Method()
        {
            return Math.Sqrt(Math.Pow(katet, 2) * Math.Pow(katet2, 2));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
