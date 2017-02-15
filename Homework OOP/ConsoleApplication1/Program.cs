using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Person per = new Person()
            {
                name = "Jason",
                surname = "Hutson",
                age = 45,
                experience = 15
            };

            Lecturer lec = new Lecturer()
            {
                name = "Hutch",
                surname = "Miachels",
                age = 62,
                experience = 35,
                university = "Harvard University"
            };

            lec.ToString();

            Teacher teach = new Teacher()
            {
                name = "Lucille",
                surname = "Lakes",
                teaching = "Software Engineering",
                age = 43,
                experience = 10
            };

            teach.ToString();


        }
    }
}
