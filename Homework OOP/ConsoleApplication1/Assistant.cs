using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Assistant: Lecturer
    {
       private bool mainassistant = true;

       private void present()
       {
           Console.WriteLine("My name is {0} {1} and it is {2} that i am the main assistant", name, surname, mainassistant);

       }
       private void writing()
       {
           Console.WriteLine("Writing science facts");
       }

       public override void checkhomework()
       {
           Console.WriteLine("Time to check your homework");
       }

        public Assistant()
        {
            name = this.name;
            surname = this.surname;
            experience = this.experience;
            university = this.university;
        }
    }
}
