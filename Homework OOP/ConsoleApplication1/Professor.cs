using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Professor: Lecturer
    {
        private string rank { get; set; }

        private void present()
        {
            Console.WriteLine("I am a {0} and i have {1} years of experience", this.rank, hours);
        }

        public override void checkhomework()
        {
            Console.WriteLine("Time to start out lecture");
        }

        public Professor()
        {
            name = this.name;
            surname = this.surname;
            experience = this.experience;
            rank = this.rank;
            university = this.university;
        }

        public override string ToString()
        {
            return string.Format("{} {} is my name i am a {} at {}", name, surname, rank, university);
        }
    }
}
