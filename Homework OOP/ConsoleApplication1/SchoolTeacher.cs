using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class SchoolTeacher: Teacher
    {
       private string[] classes = new string[5] { "1A", "2B", "3C", "4E", "5D" };

        public override void checkhomework()
        {
            Console.WriteLine("Give me your homework");
        }
        private void allclasses()
        {
            Console.Write("I teach are ");
            for (int i = 0; i < classes.Length ; i++)
            {
                
                Console.Write(i + " ");
            }
        }
        private void entertain()
        {
            Console.WriteLine("Entertaining children");
        }

        public SchoolTeacher()
        {
            name = this.name;
            surname = this.surname;
            experience = this.experience;
            teaching = this.teaching;
        }

        public override string ToString()
        {
            return string.Format("My name is {0} {1} i have {2} experience in teaching {3}", name,surname, experience, teaching);
        }
    }
}
