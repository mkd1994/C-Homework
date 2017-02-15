using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Lecturer: Person
    {
        public string university { get; set; }

        protected const int hours = 10;

        public abstract void checkhomework()
        { }

        protected void teaching()
        {
        }
        private void teaching(string a)
        {
        }
        private void teaching(string a, string b)
        { }

        public Lecturer()
        {
            
        }

        public Lecturer(string a)
        {
            name = this.name;
            university = this.university;
            surname = a;
            experience = this.experience;
        }

        protected void greet()
        {
            Console.WriteLine("Hello");
        }
    }
}
