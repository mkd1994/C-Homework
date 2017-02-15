using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class CollegeTeacher: Teacher
    {
        private string collegename = "Howards tech school";

        public override void checkhomework()
        {
            Console.WriteLine("Give me your homework");
        }

        public CollegeTeacher()
        {
            name = this.name;
            surname = this.surname;
            experience = this.experience;
            teaching = this.teaching;
        }

        public override string ToString()
        {
            return string.Format("I am a College teacher at {0} i have been teaching {1} for {2} years and my name is {3} {4}", collegename, teaching, experience, name, surname);
        }
    }
}
